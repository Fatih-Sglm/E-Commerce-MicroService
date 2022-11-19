using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.PaymentService.Api.IntegrationEvents.Events
{
    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public string ErrorMessage { get; set; }

        public OrderPaymentFailedIntegrationEvent(Guid orderId, string errorMessage)
        {
            OrderId = orderId;
            ErrorMessage = errorMessage;
        }
    }
}
