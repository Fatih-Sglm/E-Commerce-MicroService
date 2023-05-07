using E_Commerce.BasketService.Application.IntegrationEvents.Events;
using E_Commerce.BasketService.Application.IntegrationEvents.EventsHandler;
using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;
using RabbitMQ.Client;

namespace E_Commerce.BasketService.Api.Extensions
{
    public static class EventBusRegistration
    {
        public static IEventBus EventBusRegister(this IServiceProvider service , IConfiguration configuration)
        {
            EventBusConfig config = new()
            {
                ConnectionRetryCount = 5,
                EventNameSuffix = "IntegrationEvent",
                SubscriberClientAppName = "BasketService",
                EventBusType = EventBusType.RabbitMQ,
                Connection = configuration.GetValue<ConnectionFactory>("RabbitMq")
            };
            return EventBusFactory.Create(config, service);
        }
        public static void EventConfig(this WebApplication application)
        {
            var eventbus = application.Services.GetRequiredService<IEventBus>();
            eventbus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventEventEventHandler>();
        }
    }
}
