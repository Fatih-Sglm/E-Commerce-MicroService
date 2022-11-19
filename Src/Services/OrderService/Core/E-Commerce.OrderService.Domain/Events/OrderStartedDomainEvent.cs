using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using MediatR;

namespace E_Commerce.OrderService.Domain.Events
{
    public class OrderStartedDomainEvent : INotification
    {
        public string UserName { get; }
        public int CardTypeId { get; }
        public CreditCardInformation CreditCardInformation { get; }

        public bool WillPaymentRecord { get; }
        public Order Order { get; }


        public OrderStartedDomainEvent(Order order, string userName,
                                       int cardTypeId, CreditCardInformation creditCardInformation, bool willPaymentRecord)
        {
            Order = order;
            UserName = userName;
            CardTypeId = cardTypeId;
            CreditCardInformation = creditCardInformation;
            WillPaymentRecord = willPaymentRecord;
        }
    }
}
