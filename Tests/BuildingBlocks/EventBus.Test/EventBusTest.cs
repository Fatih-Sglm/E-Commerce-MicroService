using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;
using EventBus.Test.Event.EventHandler;
using EventBus.Test.Event.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EventBus.Test
{
    public class EventBusTest
    {

        private ServiceCollection services;

        public EventBusTest()
        {
            services = new ServiceCollection();
            services.AddLogging(cfg => cfg.AddConsole());
        }

        //[Fact]
        //public void Subscribe_event_on_rabbitmq_test()
        //{

        //    services.AddSingleton(sp =>
        //    {
        //        return EventBusFactory.Create(RabbitMq(), sp);
        //    });
        //    ServiceProvider sp = services.BuildServiceProvider();

        //    var eventBus = sp.GetRequiredService<IEventBus>();

        //    eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();

        //    //eventBus.UnSubscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();

        //}

        [Fact]
        public void Subscribe_event_on_azure_test()
        {

            services.AddSingleton(sp =>
            {
                return EventBusFactory.Create(Azure(), sp);
            });
            ServiceProvider sp = services.BuildServiceProvider();

            var eventBus = sp.GetRequiredService<IEventBus>();

            eventBus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
            // eventBus.UnSubscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
            Task.Delay(2000).Wait();
        }

        //[Fact]
        //public void SendMessageToRabbitMq_test()
        //{
        //    services.AddSingleton<IEventBus>(sp =>
        //    {
        //        return EventBusFactory.Create(RabbitMq(), sp);
        //    });
        //    ServiceProvider sp = services.BuildServiceProvider();

        //    var eventBus = sp.GetRequiredService<IEventBus>();

        //    eventBus.Publish(new OrderCreatedIntegrationEvent(61));
        //}

        [Fact]
        public void SendMessageToAzure_test()
        {
            services.AddSingleton<IEventBus>(sp =>
            {
                return EventBusFactory.Create(Azure(), sp);
            });
            ServiceProvider sp = services.BuildServiceProvider();

            var eventBus = sp.GetRequiredService<IEventBus>();

            eventBus.Publish(new OrderCreatedIntegrationEvent(61));
        }

        //[Fact]
        //public void ConsumeMessageRabbitMq_test()
        //{
        //    services.AddSingleton<IEventBus>(sp =>
        //    {
        //        return EventBusFactory.Create(Azure(), sp);
        //    });
        //    ServiceProvider sp = services.BuildServiceProvider();

        //    var eventBus = sp.GetRequiredService<IEventBus>();

        //    eventBus.Publish(new OrderCreatedIntegrationEvent(61));
        //}

        //[Fact]
        //public void ConsumeMessageAzure_test()
        //{
        //    services.AddSingleton<IEventBus>(sp =>
        //    {
        //        return EventBusFactory.Create(Azure(), sp);
        //    });
        //    ServiceProvider sp = services.BuildServiceProvider();

        //    var eventBus = sp.GetRequiredService<IEventBus>();

        //    eventBus.Publish(new OrderCreatedIntegrationEvent(61));
        //}

        private static EventBusConfig Azure()
        {
            return new()
            {
                ConnectionRetryCount = 5,
                SubscriberClientAppName = "EventBusUnitTest",
                DefaultTopicName = "e_commerce_eventbus",
                EventBusType = EventBusType.AzureServiceBus,
                EventNameSuffix = "IntegrationEvent",
                EventBusConnectionString = "Endpoint=sb://e-commerce-microservice.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=3tfk8FZWIlc0XAbORaUlDXDh8oNve+wn7iMIDKjQtUY="

            };
        }

        private static EventBusConfig RabbitMq()
        {
            return new()
            {
                ConnectionRetryCount = 5,
                SubscriberClientAppName = "EventBusUnitTest",
                DefaultTopicName = "DefaultTopicName",
                EventBusType = EventBusType.RabbitMQ,
                EventNameSuffix = "IntegrationEvent",

            };
        }
    }
}
