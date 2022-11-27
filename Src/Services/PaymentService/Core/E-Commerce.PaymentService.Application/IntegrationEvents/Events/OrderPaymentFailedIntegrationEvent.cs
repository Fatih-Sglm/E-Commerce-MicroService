using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.PaymentService.Application.IntegrationEvents.Events
{
    public class OrderPaymentFailedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }

        public string UserName { get; set; }
        public string ErrorMessage { get; set; }

        public OrderPaymentFailedIntegrationEvent(Guid orderId, string userName, string errorMessage)
        {
            OrderId = orderId;
            ErrorMessage = errorMessage;
            UserName = userName;
        }
    }
}
