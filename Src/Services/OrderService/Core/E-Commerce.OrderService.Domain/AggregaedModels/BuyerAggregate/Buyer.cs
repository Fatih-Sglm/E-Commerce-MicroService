using E_Commerce.OrderService.Domain.Events;
using E_Commerce.OrderService.Domain.SeedWork;

namespace E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate
{
    public class Buyer : BaseEntity, IAggregateRoot
    {
        public string UserName { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }


        private readonly List<PaymentMethod> _paymentMethods;
        public IEnumerable<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();

        protected Buyer()
        {
            _paymentMethods = new List<PaymentMethod>();
        }

        public Buyer(string name, string fullname, string email) : this()
        {
            UserName = name ?? throw new ArgumentNullException(nameof(name));
            Fullname = fullname ?? throw new ArgumentNullException(nameof(fullname));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }


        public Task VerifyOrAddPaymentMethod(string alias, string cardNumber, string cardHolderName,
             string expirationMonth, string expirationYear, string securityNumber, int cardTypeId, Guid orderId, bool willPaymentRecord = false)
        {

            if (!willPaymentRecord)
            {
                AddDomainEvent(new BuyerAndPaymentMethodVerifiedDomainEvent(this, null, orderId));
            }
            else
            {
                var payment = _paymentMethods.SingleOrDefault(p => p.IsEqualTo(cardNumber, cardHolderName,
                     expirationMonth, expirationYear, securityNumber, cardTypeId));

                if (payment is not null)
                {
                    AddDomainEvent(new BuyerAndPaymentMethodVerifiedDomainEvent(this, payment, orderId));
                }
                else
                {
                    payment = new PaymentMethod(alias, cardNumber, cardHolderName, expirationMonth, expirationYear, securityNumber, cardTypeId);
                    _paymentMethods.Add(payment);
                    AddDomainEvent(new BuyerAndPaymentMethodVerifiedDomainEvent(this, payment, orderId));
                }
            }
            return Task.CompletedTask;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) ||
                   (obj is Buyer buyer &&
                   Id.Equals(buyer.Id) &&
                   UserName == buyer.UserName);
        }


    }
}
