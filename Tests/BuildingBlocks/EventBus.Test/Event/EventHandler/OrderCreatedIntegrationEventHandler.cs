using E_Commerce.EventBus.Base.Abstraction;
using EventBus.Test.Event.Events;

namespace EventBus.Test.Event.EventHandler
{
    public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
    {
        public Task HandleAsync(OrderCreatedIntegrationEvent @event)
        {
            Console.WriteLine($"{@event.Id} ile KOd çalıştı");
            return Task.CompletedTask;
        }
    }
}
