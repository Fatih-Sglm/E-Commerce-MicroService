using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.OrderService.Application.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {

        public string UserName { get; set; }

        public Guid OrderId { get; set; }

        public OrderStartedIntegrationEvent(string userName, Guid orderId)
        {
            UserName = userName;
            OrderId = orderId;
        }
    }
}
