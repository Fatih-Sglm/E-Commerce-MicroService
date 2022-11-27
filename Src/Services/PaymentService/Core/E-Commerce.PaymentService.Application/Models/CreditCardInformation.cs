namespace E_Commerce.PaymentService.Application.Models
{
    public class CreditCardInformation
    {
        public string Alias { get; private set; } = null;
        public string CardNumber { get; private set; }
        public string CardHolderName { get; private set; }
        public DateTime CardExpiration { get; private set; }
        public string CardSecurityNumber { get; set; }

        public CreditCardInformation(string alias, string cardNumber, string cardHolderName, DateTime cardExpiration, string cardSecurityNumber)
        {

            Alias = alias;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CardExpiration = cardExpiration;
            CardSecurityNumber = cardSecurityNumber;
        }
    }
}
