using E_Commerce.BasketService.Application.IntegrationEvents.Events;
using E_Commerce.BasketService.Application.IntegrationEvents.EventsHandler;
using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;

namespace E_Commerce.BasketService.Api.Extensions
{
    public static class EventBusRegistration
    {
        public static IEventBus EventBusRegister(this IServiceProvider service)
        {
            EventBusConfig config = new()
            {
                ConnectionRetryCount = 5,
                EventNameSuffix = "IntegrationEvent",
                SubscriberClientAppName = "BasketService",
                EventBusType = EventBusType.RabbitMQ
            };
            return EventBusFactory.Create(config, service);
        }
        public static void EventConfig(this WebApplication application)
        {
            var eventbus = application.Services.GetRequiredService<IEventBus>();
            eventbus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
        }
    }
}
