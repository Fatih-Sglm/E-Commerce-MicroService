using E_Commerce.EventBus.Base.Events;
using E_Commerce.PaymentService.Application.Models;

namespace E_Commerce.PaymentService.Application.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {

        public CreditCardInformation CreditCardInformation { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid OrderId { get; set; }

        public OrderStartedIntegrationEvent(CreditCardInformation creditCardInformation, string userName, string name, string email, Guid orderId)
        {
            CreditCardInformation = creditCardInformation;
            UserName = userName;
            Name = name;
            Email = email;
            OrderId = orderId;
        }
    }
}
