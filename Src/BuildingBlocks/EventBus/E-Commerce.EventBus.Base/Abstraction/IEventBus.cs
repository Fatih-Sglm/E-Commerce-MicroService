using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.EventBus.Base.Abstraction
{
    public interface IEventBus : IDisposable
    {
        void Publish(IntegrationEvent @event);

        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;

    }
}
