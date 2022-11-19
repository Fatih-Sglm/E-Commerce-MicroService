namespace E_Commerce.OrderService.Application.Features.Orders.Models
{
    public class CreditCardInformation
    {
        public string CardNumber { get; private set; }

        public string CardHolderName { get; private set; }

        public DateTime CardExpiration { get; private set; }
        public string CardSecurityNumber { get; set; }

        public CreditCardInformation(string cardNumber, string cardHolderName, DateTime cardExpiration, string cardSecurityNumber)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CardExpiration = cardExpiration;
            CardSecurityNumber = cardSecurityNumber;
        }
    }
}
