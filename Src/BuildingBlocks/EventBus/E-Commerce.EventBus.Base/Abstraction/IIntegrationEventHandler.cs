using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.EventBus.Base.Abstraction
{
    public interface IIntegrationEventHandler<T> : IntegrationEventHandler where T : IntegrationEvent
    {
        Task HandleAsync(T @event);
    }
}
