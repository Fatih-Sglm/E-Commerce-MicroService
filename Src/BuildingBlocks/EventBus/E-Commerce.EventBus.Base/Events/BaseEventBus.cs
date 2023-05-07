using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Base.SubManagers;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace E_Commerce.EventBus.Base.Events
{
    public abstract class BaseEventBus : IEventBus
    {
        public readonly IServiceProvider ServiceProvider;
        public readonly IEventBusSubscriptionManager SubsManager;

        public EventBusConfig EventBusConfig { get; private set; }

        public BaseEventBus(EventBusConfig config, IServiceProvider serviceProvider)
        {
            EventBusConfig = config;
            ServiceProvider = serviceProvider;
            SubsManager = new InMemoryEventBusSubscriptionManager(ProcessEventName);
        }

        public virtual string ProcessEventName(string eventName)
        {
            if (EventBusConfig.DeleteEventPrefix)
                eventName = eventName.Contains(EventBusConfig.EventNamePrefix) ? eventName[EventBusConfig.EventNamePrefix.Length..] : eventName;
            eventName = eventName[EventBusConfig.EventNamePrefix.Length..];

            if (EventBusConfig.DeleteEventSuffix)
                eventName = eventName.Contains(EventBusConfig.EventNameSuffix) ? eventName[..(eventName.Length - EventBusConfig.EventNameSuffix.Length)] : eventName;

            return eventName;
        }

        public virtual string GetSubName(string eventName)
        {
            return $"{EventBusConfig?.SubscriberClientAppName}.{ProcessEventName(eventName)}";
        }



        public async Task<bool> ProcessEvent(string eventName, string message)
        {
            eventName = ProcessEventName(eventName);

            bool processed = false;

            if (SubsManager.HasSubscriptionsForEvent(eventName))
            {
                var subscriptions = SubsManager.GetHandlersForEvent(eventName);

                using (var scope = ServiceProvider.CreateScope())
                {
                    foreach (var subscription in subscriptions)
                    {
                        var handler = ServiceProvider.GetService(subscription.HandlerType);
                        if (handler == null) continue;

                        var eventType = SubsManager.GetEventTypeByName($"{EventBusConfig!.EventNamePrefix}{eventName}{EventBusConfig.EventNameSuffix}");
                        var integrationEvent = JsonConvert.DeserializeObject(message, eventType);

                        var concreteType = typeof(IIntegrationEventHandler<>).MakeGenericType(eventType);
                        await Task.FromResult(concreteType.GetMethod("HandleAsync")!.Invoke(handler, new object[] { integrationEvent }));
                    }
                }

                processed = true;
            }

            return processed;
        }




        public abstract void Publish(IntegrationEvent @event);

        public abstract void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

        public abstract void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;



        public virtual void Dispose()
        {

            EventBusConfig = null;
            SubsManager.Clear();

        }
    }
}
