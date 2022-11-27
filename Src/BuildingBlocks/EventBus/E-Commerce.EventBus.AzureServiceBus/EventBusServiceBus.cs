//using E_Commerce.EventBus.Base.EventBus.Base;
//using E_Commerce.EventBus.Base.Events;
//using Microsoft.Azure.ServiceBus;
//using Microsoft.Azure.ServiceBus.Management;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
//using System.Text;

//namespace E_Commerce.EventBus.AzureServiceBus
//{
//    public class EventBusServiceBus : BaseEventBus
//    {
//        private ITopicClient _topicClient;
//        private ManagementClient _managementClient;
//        private readonly ILogger _logger;

//        public EventBusServiceBus(EventBusConfig config, IServiceProvider serviceProvider) : base(config, serviceProvider)
//        {
//            _logger = serviceProvider.GetRequiredService<ILogger<EventBusServiceBus>>();
//            _managementClient = new ManagementClient(config.EventBusConnectionString);
//            _topicClient = CreateTopicClient();

//        }

//        private ITopicClient CreateTopicClient()
//        {
//            if (_topicClient == null || _topicClient.IsClosedOrClosing)
//            {
//                _topicClient = new TopicClient(EventBusConfig.EventBusConnectionString, EventBusConfig.DefaultTopicName, RetryPolicy.Default);
//            }
//            if (!_managementClient.TopicExistsAsync(EventBusConfig.DefaultTopicName).GetAwaiter().GetResult())
//            {
//                _managementClient.CreateTopicAsync(EventBusConfig.DefaultTopicName).GetAwaiter().GetResult();
//            }
//            return _topicClient;
//        }

//        public override void Publish(IntegrationEvent @event)
//        {
//            string eventname = @event.GetType().Name;
//            eventname = ProcessEventName(eventname);
//            Message Message = new()
//            {
//                MessageId = Guid.NewGuid().ToString(),
//                Body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(@event)),
//                Label = eventname
//            };
//            _topicClient.SendAsync(Message).GetAwaiter().GetResult();
//        }

//        public override void Subscribe<T, TH>()
//        {
//            string eventName = typeof(T).Name;
//            eventName = ProcessEventName(eventName);
//            if (!SubsManager.HasSubscriptionsForEvent(eventName))
//            {
//                ISubscriptionClient subClient = CreateSubscriptionClientIfNoExist(eventName);
//                RegisterSubscriptionClientMessageHandler(subClient);
//            }
//            _logger.LogInformation("Subscribing to event {EventName} with {EventHandler}", eventName, typeof(TH).Name);
//            SubsManager.AddSubscription<T, TH>();
//        }

//        public override void UnSubscribe<T, TH>()
//        {
//            var eventName = typeof(T).Name;

//            try
//            {
//                // Subscription will be there but we don't subscribe
//                var subscriptionClient = CreateSubscriptionClient(eventName);

//                subscriptionClient
//                    .RemoveRuleAsync(eventName)
//                    .GetAwaiter()
//                    .GetResult();
//            }
//            catch (MessagingEntityNotFoundException)
//            {
//                _logger.LogWarning("The messaging entity {eventName} Could not be found.", eventName);
//            }

//            _logger.LogInformation("Unsubscribing from event {EventName}", eventName);

//            SubsManager.RemoveSubscription<T, TH>();
//        }
//        private ISubscriptionClient CreateSubscriptionClientIfNoExist(string eventname)
//        {
//            SubscriptionClient subclient = CreateSubscriptionClient(eventname);
//            bool exist = _managementClient.SubscriptionExistsAsync(EventBusConfig.DefaultTopicName, GetSubName(eventname)).GetAwaiter().GetResult();
//            if (!exist)
//            {
//               _managementClient.CreateSubscriptionAsync(EventBusConfig.DefaultTopicName, GetSubName(eventname)).GetAwaiter().GetResult();
//                RemoveDefaultRule(subclient);
//            }
//            CreateRuleIfNotExists(ProcessEventName(eventname), subclient);

//            return subclient;
//        }

//        private void RegisterSubscriptionClientMessageHandler(ISubscriptionClient subscriptionClient)
//        {
//            subscriptionClient.RegisterMessageHandler(
//                async (message, token) =>
//                {
//                    var eventName = $"{message.Label}";
//                    var messageData = Encoding.UTF8.GetString(message.Body);

//                    // Complete the message so that it is not received again.
//                    if (await ProcessEvent(ProcessEventName(eventName), messageData))
//                    {
//                        await subscriptionClient.CompleteAsync(message.SystemProperties.LockToken);
//                    }
//                },
//                new MessageHandlerOptions(ExceptionReceivedHandler) { MaxConcurrentCalls = 10, AutoComplete = false });
//        }

//        private Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
//        {
//            var ex = exceptionReceivedEventArgs.Exception;
//            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;

//            _logger.LogError(ex, "ERROR handling message: {ExceptionMessage} - Context: {@ExceptionContext}", ex.Message, context);

//            return Task.CompletedTask;
//        }
//        private void CreateRuleIfNotExists(string eventName, ISubscriptionClient subscriptionClient)
//        {
//            bool ruleExits;

//            try
//            {
//                var rule = _managementClient.GetRuleAsync(EventBusConfig.DefaultTopicName, GetSubName(eventName), eventName).GetAwaiter().GetResult();
//                ruleExits = rule != null;
//            }
//            catch (MessagingEntityNotFoundException)
//            {
//                // Azure Management Client doesn't have RuleExists method
//                ruleExits = false;
//            }

//            if (!ruleExits)
//            {
//                subscriptionClient.AddRuleAsync(new RuleDescription
//                {
//                    Filter = new CorrelationFilter { Label = eventName },
//                    Name = eventName
//                }).GetAwaiter().GetResult();
//            }
//        }

//        private void RemoveDefaultRule(SubscriptionClient subscriptionClient)
//        {
//            try
//            {
//                subscriptionClient.RemoveRuleAsync(RuleDescription.DefaultRuleName).GetAwaiter().GetResult();
//            }
//            catch (MessagingEntityNotFoundException)
//            {
//                _logger.LogWarning($"The messaging entity {RuleDescription.DefaultRuleName} Could not be found");
//            }
//        }

//        private SubscriptionClient CreateSubscriptionClient(string eventname)
//        {
//            return new SubscriptionClient(EventBusConfig.EventBusConnectionString, EventBusConfig.DefaultTopicName, GetSubName(eventname));
//        }
//        public override void Dispose()
//        {
//            base.Dispose();
//            _topicClient.CloseAsync().GetAwaiter().GetResult();
//            _managementClient.CloseAsync().GetAwaiter().GetResult();
//            _topicClient = null;
//            _managementClient = null;
//        }
//    }
//}
