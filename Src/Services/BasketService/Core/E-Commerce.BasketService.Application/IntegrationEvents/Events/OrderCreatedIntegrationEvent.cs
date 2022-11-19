using E_Commerce.BasketService.Domain.Models;
using E_Commerce.EventBus.Base.Events;

namespace E_Commerce.BasketService.Application.IntegrationEvents.Events
{
    public class OrderCreatedIntegrationEvent : IntegrationEvent
    {
        public string UserName { get; }
        public int OrderNumber { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public CreditCardInformation CreditCardInformation { get; private set; }
        public int CardTypeId { get; private set; }
        public bool WillPaymentRecorded { get; private set; }
        public CustomerBasket Basket { get; }
        public OrderCreatedIntegrationEvent(string userName, string city, string street,
            string state, string country, string zipCode, string Alias, string cardNumber, string cardHolderName,
            DateTime cardExpiration, string cardSecurityNumber, int cardTypeId,
            CustomerBasket basket, bool willPaymentRecorded = false)
        {
            Random rnd = new();
            UserName = userName;
            City = city;
            WillPaymentRecorded = willPaymentRecorded;
            CreditCardInformation = new(Alias, cardNumber, cardHolderName, cardExpiration, cardSecurityNumber);
            OrderNumber = rnd.Next(111111111, 999999999);
            Street = street;
            State = state;
            Country = country;
            ZipCode = zipCode;
            CardTypeId = cardTypeId;
            Basket = basket;
        }

    }
}
