namespace E_Commerce.BasketService.Domain.Models
{
    public class CreditCardInformation
    {
        public string Alias { get; private set; } = null;
        public string CardNumber { get; private set; }

        public string CardHolderName { get; private set; }

        public DateTime CardExpiration { get; private set; }
        public string CardSecurityNumber { get; set; }

        {

            Alias = alias;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CardExpiration = cardExpiration;
            CardSecurityNumber = cardSecurityNumber;
        }
    }
}
