using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.PaymentService.Application.IntegrationEvents.Events
{
    public class OrderPaymentSuccesIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; set; }
        public string UserName { get; set; }

        public OrderPaymentSuccesIntegrationEvent(Guid orderId, string userName)
        {
            OrderId = orderId;
            UserName = userName;
        }
    }
}
