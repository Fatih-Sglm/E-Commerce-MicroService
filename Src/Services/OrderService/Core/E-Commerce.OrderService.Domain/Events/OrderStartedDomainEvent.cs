using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using E_Commerce.OrderService.Domain.Models;
using MediatR;

namespace E_Commerce.OrderService.Domain.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int CardTypeId { get; }
        public CreditCardInformation CreditCardInformation { get; }

        public bool WillPaymentRecord { get; }
        public Order Order { get; }


        public OrderStartedDomainEvent(Order order, string userName, string fullName, string email,
                                       int cardTypeId, CreditCardInformation creditCardInformation, bool willPaymentRecord)
        {
            Order = order;
            UserName = userName;
            FullName = fullName;
            Email = email;
            CardTypeId = cardTypeId;
            CreditCardInformation = creditCardInformation;
            WillPaymentRecord = willPaymentRecord;
        }
    }
}
