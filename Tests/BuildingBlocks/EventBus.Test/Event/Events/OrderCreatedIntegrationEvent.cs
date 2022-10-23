using E_Commerce.EventBus.Base.Events;

namespace EventBus.Test.Event.Events
{
    public class OrderCreatedIntegrationEvent : IntegrationEvent
    {
        public int Id { get; set; }

        public OrderCreatedIntegrationEvent(int id)
        {
            Id = id;
        }
    }
}
