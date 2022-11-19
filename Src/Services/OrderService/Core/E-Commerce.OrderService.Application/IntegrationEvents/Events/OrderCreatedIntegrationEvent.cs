using E_Commerce.EventBus.Base.Events;
using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Domain.Models;

namespace E_Commerce.OrderService.Application.IntegrationEvents.Events
{
    public class OrderCreatedIntegrationEvent : IntegrationEvent
    {
        public string UserId { get; }

        public string UserName { get; }

        public int OrderNumber { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public CreditCardInformation CreditCardInformation { get; private set; }

        public int CardTypeId { get; set; }

        public bool WillPaymentRecorded { get; set; }
        public CustomerBasket Basket { get; }

        //public OrderCreatedIntegrationEvent(string userId, string userName, string city, string street,
        //    string state, string country, string zipCode, string cardNumber, string cardHolderName,
        //    DateTime cardExpiration, string cardSecurityNumber, int cardTypeId, Guid orderNumber,
        //    CustomerBasket basket)
        //{
        //    UserId = userId;
        //    UserName = userName;
        //    City = city;
        //    OrderNumber = orderNumber;
        //    Street = street;
        //    State = state;
        //    Country = country;
        //    ZipCode = zipCode;
        //    CardNumber = cardNumber;
        //    CardHolderName = cardHolderName;
        //    CardExpiration = cardExpiration;
        //    CardSecurityNumber = cardSecurityNumber;
        //    CardTypeId = cardTypeId;
        //    Basket = basket;
        //}

    }
}
