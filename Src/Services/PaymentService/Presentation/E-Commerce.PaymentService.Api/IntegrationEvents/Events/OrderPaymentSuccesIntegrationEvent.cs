using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.PaymentService.Api.IntegrationEvents.Events
{
    public class OrderPaymentSuccesIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public OrderPaymentSuccesIntegrationEvent(Guid orderId)
        {
            OrderId = orderId;
        }
    }
}
