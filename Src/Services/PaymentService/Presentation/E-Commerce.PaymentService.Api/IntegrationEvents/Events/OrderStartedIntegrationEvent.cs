using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.PaymentService.Api.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {
        public OrderStartedIntegrationEvent()
        {
        }

        public Guid OrderId { get; set; }

        public OrderStartedIntegrationEvent(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
