using E_Commerce.EventBus.Base.Events;
using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Domain.Models;

namespace E_Commerce.OrderService.Application.IntegrationEvents.Events
{
    public class OrderCreatedIntegrationEvent : IntegrationEvent
    {
        public string UserId { get; }

        public string UserName { get; }

        public uint OrderNumber { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public CreditCardInformation CreditCardInformation { get; private set; }

        public int CardTypeId { get; set; }

        public bool WillPaymentRecorded { get; set; }

        public string? Alias { get; set; }
        public CustomerBasket Basket { get; }

        public OrderCreatedIntegrationEvent(string userName, string city, string street,
            string state, string country, string zipCode, CreditCardInformation creditCardInformation, int cardTypeId, uint orderNumber,
            CustomerBasket basket, string? alias)
        {
            UserName = userName;
            City = city;
            OrderNumber = orderNumber;
            Street = street;
            CreditCardInformation = creditCardInformation;
            State = state;
            Country = country;
            ZipCode = zipCode;
            CardTypeId = cardTypeId;
            Basket = basket;
            Alias = alias;
        }

    }
}
