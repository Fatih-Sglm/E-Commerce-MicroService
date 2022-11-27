using Azure.Messaging.ServiceBus;
using Azure.Messaging.ServiceBus.Administration;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Base.Events;
using Newtonsoft.Json;
using System.Text;

namespace E_Commerce.EventBus.AzureServiceBus
{
    public class EventBusServiceBusNew : BaseEventBus
    {

        private readonly ServiceBusAdministrationClient _serviceBusAdmin;
        private ServiceBusReceiver _receiver;
        public EventBusServiceBusNew(EventBusConfig config, IServiceProvider serviceProvider) : base(config, serviceProvider)
        {
            _serviceBusAdmin = new ServiceBusAdministrationClient(config.EventBusConnectionString);

            CreateTopic();
        }

        private void CreateTopic()
        {
            var exist = _serviceBusAdmin.TopicExistsAsync(EventBusConfig.DefaultTopicName).GetAwaiter().GetResult();
            if (!exist)
                _serviceBusAdmin.CreateTopicAsync(EventBusConfig!.DefaultTopicName).GetAwaiter().GetResult();
        }


        private ServiceBusClient CreateClient()
        {
            ServiceBusClientOptions options = new()
            {
                TransportType = ServiceBusTransportType.AmqpWebSockets
            };

            return new(EventBusConfig!.EventBusConnectionString, options);
        }

        private ServiceBusSender CreateSender()
        {
            var _client = CreateClient();
            return _client.CreateSender(EventBusConfig.DefaultTopicName);
        }

        private ServiceBusReceiver CreateReceiver(string eventName)
        {
            var _client = CreateClient();
            return _client.CreateReceiver(EventBusConfig.DefaultTopicName, GetSubName(eventName), new ServiceBusReceiverOptions { ReceiveMode = ServiceBusReceiveMode.PeekLock });
        }

        public override void Publish(IntegrationEvent @event)
        {
            string eventname = @event.GetType().Name;
            eventname = ProcessEventName(eventname);
            bool queueExists = _serviceBusAdmin.SubscriptionExistsAsync(EventBusConfig.DefaultTopicName, eventname).GetAwaiter().GetResult();
            if (!queueExists)
            {
                _serviceBusAdmin.SubscriptionExistsAsync(EventBusConfig.DefaultTopicName, eventname).GetAwaiter().GetResult();
            }
            var _sender = CreateSender();
            BinaryData binaryData = new(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(@event)));
            ServiceBusMessage Message = new()
            {
                Body = binaryData,
                MessageId = Guid.NewGuid().ToString(),
                Subject = eventname
            };
            _sender.SendMessageAsync(Message).GetAwaiter().GetResult();
        }

        public override void Subscribe<T, TH>()
        {

            string eventName = typeof(T).Name;
            eventName = ProcessEventName(eventName);
            if (!SubsManager.HasSubscriptionsForEvent(eventName))
            {

                _receiver = CreateReceiver(eventName);
                CreateSubscriptionClientIfNoExist(eventName);
                RegisterSubscriptionClientMessageHandler(eventName);
            }

            SubsManager.AddSubscription<T, TH>();

        }

        private void RegisterSubscriptionClientMessageHandler(string eventName)
        {
            if (_serviceBusAdmin.SubscriptionExistsAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName)).GetAwaiter().GetResult())
            {
                ServiceBusReceivedMessage? message = _receiver.ReceiveMessageAsync().GetAwaiter().GetResult();
                if (message != null)
                {
                    var body = Encoding.UTF8.GetString(message.Body);
                    ProcessEvent(ProcessEventName(eventName), body).GetAwaiter().GetResult();
                }
            }
        }

        //public override void Subscribe<T, TH>()
        //        {
        //            string eventName = typeof(T).Name;
        //            eventName = ProcessEventName(eventName);
        //            if (!SubsManager.HasSubscriptionsForEvent(eventName))
        //            {
        //                ISubscriptionClient subClient = CreateSubscriptionClientIfNoExist(eventName);
        //                W(subClient);
        //            }
        //            _logger.LogInformation("Subscribing to event {EventName} with {EventHandler}", eventName, typeof(TH).Name);
        //            SubsManager.AddSubscription<T, TH>();
        //        }


        private void RemoveDefaultRule(string eventName)
        {
            bool isDefaultRuleExist = _serviceBusAdmin.RuleExistsAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName), RuleProperties.DefaultRuleName).GetAwaiter().GetResult();
            if (isDefaultRuleExist)
                _serviceBusAdmin.DeleteRuleAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName), RuleProperties.DefaultRuleName).GetAwaiter().GetResult();
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    _logger.LogWarning($"The messaging entity {RuleDescription.DefaultRuleName} Could not be found");
            //}
        }

        private void CreateRuleIfNotExists(string eventName)
        {
            var ruleExits = _serviceBusAdmin.RuleExistsAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName), eventName).GetAwaiter().GetResult();
            if (!ruleExits)
            {
                _serviceBusAdmin.CreateRuleAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName), new()
                {
                    Filter = new CorrelationRuleFilter() { Subject = eventName },
                    Name = eventName
                }).GetAwaiter().GetResult();
            }
        }

        private void CreateSubscriptionClientIfNoExist(string eventName)
        {

            bool exist = _serviceBusAdmin.SubscriptionExistsAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName)).GetAwaiter().GetResult();
            if (!exist)
                _serviceBusAdmin.CreateSubscriptionAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName)).GetAwaiter().GetResult();
            RemoveDefaultRule(ProcessEventName(eventName));
            CreateRuleIfNotExists(ProcessEventName(eventName));
        }

        //private SubscriptionProperties CreateSubscriptionClient(string eventname)
        //{
        //    return _serviceBusAdmin.CreateSubscriptionAsync(EventBusConfig.DefaultTopicName, GetSubName(eventname)).GetAwaiter().GetResult();
        //}
        //public override void Dispose()
        //{
        //    base.Dispose();
        //    _topicClient.CloseAsync().GetAwaiter().GetResult();
        //    _managementClient.CloseAsync().GetAwaiter().GetResult();
        //    _topicClient = null;
        //    _managementClient = null;
        //}

        public override void UnSubscribe<T, TH>()
        {
            throw new NotImplementedException();
        }
    }
}
