using E_Commerce.EventBus.Base.Events;
using E_Commerce.PaymentService.Api.Models;

namespace E_Commerce.PaymentService.Api.IntegrationEvents.Events
{
    public class OrderStartedIntegrationEvent : IntegrationEvent
    {
        public OrderStartedIntegrationEvent()
        {
        }

        public int OrderId { get; set; }

        public OrderStartedIntegrationEvent(int orderId)
        {
            CreditCardInformation = creditCardInformation;
            Name = name;
            Email = email;
            OrderId = orderId;
        }
    }
}
