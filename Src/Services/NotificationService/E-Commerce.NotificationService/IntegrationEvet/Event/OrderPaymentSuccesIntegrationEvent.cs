using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.NotificationService.IntegrationEvet.Event
{
    public class OrderPaymentSuccesIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; set; }

        public OrderPaymentSuccesIntegrationEvent(int orderId)
        {
            OrderId = orderId;
        }
    }
}
