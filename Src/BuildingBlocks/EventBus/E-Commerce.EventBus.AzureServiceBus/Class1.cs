//using Azure.Messaging.ServiceBus;
//using E_Commerce.EventBus.Base.EventBus.Base;
//using E_Commerce.EventBus.Base.Events;
//using Newtonsoft.Json;

//namespace E_Commerce.EventBus.AzureServiceBus
//{
//    public class EventBusServiceBusNew : BaseEventBus
//    {
//        private readonly ServiceBusClientOptions options = new();
//        private readonly ServiceBusClient _client;
//        private ServiceBusSender _sender;
//        private EventBusConfig cfg;
//        public Class1(EventBusConfig config, IServiceProvider serviceProvider) : base(config, serviceProvider)
//        {
//            cfg = config;
//            options.TransportType = ServiceBusTransportType.AmqpWebSockets;
//            _client = new(config.EventBusConnectionString, options);

//        }

//        public override void Publish(IntegrationEvent @event)
//        {
//            string eventname = @event.GetType().Name;
//            eventname = ProcessEventName(cfg.DefaultTopicName);
//            _sender = _client.CreateSender(eventname);
//            ServiceBusMessage Message = new(JsonConvert.SerializeObject(@event));
//            _sender.SendMessageAsync(Message).GetAwaiter().GetResult();
//        }

//        //public override void Publish(IntegrationEvent @event)
//        //{
//        //    string eventname = @event.GetType().Name;
//        //    eventname = ProcessEventName(eventname);
//        //    Message Message = new()
//        //    {
//        //        MessageId = Guid.NewGuid().ToString(),
//        //        Body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(@event)),
//        //        Label = eventname
//        //    };
//        //    _topicClient.SendAsync(Message).GetAwaiter().GetResult();
//        //}

//        public override void Subscribe<T, TH>()
//        {
//            string eventName = typeof(T).Name;
//            eventName = ProcessEventName(eventName);
//            if (!SubsManager.HasSubscriptionsForEvent(eventName))
//            {
//                _sender = _client.CreateSender(eventName);
//            }
//        }

//        //public override void Subscribe<T, TH>()
//        //        {
//        //            string eventName = typeof(T).Name;
//        //            eventName = ProcessEventName(eventName);
//        //            if (!SubsManager.HasSubscriptionsForEvent(eventName))
//        //            {
//        //                ISubscriptionClient subClient = CreateSubscriptionClientIfNoExist(eventName);
//        //                RegisterSubscriptionClientMessageHandler(subClient);
//        //            }
//        //            _logger.LogInformation("Subscribing to event {EventName} with {EventHandler}", eventName, typeof(TH).Name);
//        //            SubsManager.AddSubscription<T, TH>();
//        //        }


//        public override void UnSubscribe<T, TH>()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
