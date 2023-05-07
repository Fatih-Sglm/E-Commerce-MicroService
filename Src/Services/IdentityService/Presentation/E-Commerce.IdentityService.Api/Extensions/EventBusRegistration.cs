using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;
using E_Commerce.IdentityService.Application.IntegrationEvents;

namespace E_Commerce.IdentityService.Api.Extensions
{
    public static class EventBusRegistration
    {

        public static IEventBus EventBusRegister(this IServiceProvider service, IConfiguration configuration)
        {
            var busConfig = configuration.GetSection("EventBusConfig").Get<EventBusConfig>();
            if (busConfig == null)
                throw new ArgumentNullException(nameof(busConfig));

            //EventBusConfig config = new()
            //{
            //    ConnectionRetryCount = 5,
            //    EventNameSuffix = "IntegrationEvent",
            //    SubscriberClientAppName = "BasketService",
            //    EventBusType = EventBusType.RabbitMQ,
            //    Connection = configuration.GetValue<ConnectionFactory>("RabbitMq")
            //};
            return EventBusFactory.Create(busConfig, service);
        }
    }
}

