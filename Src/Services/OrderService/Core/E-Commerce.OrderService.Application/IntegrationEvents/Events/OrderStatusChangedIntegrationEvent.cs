using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.OrderService.Application.IntegrationEvents.Events
{
    public class OrderStatusChangedIntegrationEvent : IntegrationEvent
    {
        public Guid OrderId { get; private set; }
        public string OrderStatus { get; private set; }

        public OrderStatusChangedIntegrationEvent(Guid orderId, string orderStatus)
        {
            OrderId = orderId;
            OrderStatus = orderStatus;
        }
    }
}
