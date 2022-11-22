using E_Commerce.EventBus.Base.Events;
using E_Commerce.OrderService.Application.Features.Orders.Models;

namespace E_Commerce.OrderService.Application.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {
        public CreditCardInformation CreditCardInformation { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Guid OrderId { get; private set; }

        public OrderStartedIntegrationEvent(CreditCardInformation creditCardInformation, string name, string email, Guid orderId)
        {
            CreditCardInformation = creditCardInformation;
            Name = name;
            Email = email;
            OrderId = orderId;
        }
    }
}
