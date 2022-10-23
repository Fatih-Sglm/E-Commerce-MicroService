using E_Commerce.EventBus.AzureServiceBus;
using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.RabbitMq;

namespace E_Commerce.EventBus.Factory
{
    public class EventBusFactory
    {
        public static IEventBus Create(EventBusConfig config, IServiceProvider serviceProvider)
        {
            return config.EventBusType switch
            {
                EventBusType.AzureServiceBus => new EventBusServiceBus(config, serviceProvider),
                _ => new EventBusRabbitMQ(config, serviceProvider)
            };
        }
    }
}
