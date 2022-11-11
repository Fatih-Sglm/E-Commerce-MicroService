using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Domain.Events;
using E_Commerce.OrderService.Domain.SeedWork;

namespace E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }

        public int Quantity { get; private set; }

        public string? Description { get; private set; }

        public Guid? BuyerId { get; private set; }

        public Buyer Buyer { get; private set; }

        public Address Address { get; private set; }

        private int orderStatusId;
        public OrderStatus OrderStatus { get; private set; }

        private readonly List<OrderItem> _orderItems;
        public IEnumerable<OrderItem> OrderItems => _orderItems.AsReadOnly();

        public Guid? PaymentMethodId { get; set; }

        protected Order()
        {
            Id = Guid.NewGuid();
            _orderItems = new List<OrderItem>();
        }

        public Order(string userName, Address address, int cardTypeId, string cardNumber, string cardSecurityNumber,
                string cardHolderName, DateTime cardExpiration, int quantity, Guid? paymentMethodId, Guid? buyerId = null) : this()
        {
            BuyerId = buyerId;
            orderStatusId = OrderStatus.Submitted.Id;
            OrderDate = DateTime.UtcNow;
            Address = address;
            PaymentMethodId = paymentMethodId;
            Quantity = quantity;

            AddOrderStartedDomainEvent(userName, cardTypeId, cardNumber,
                                       cardSecurityNumber, cardHolderName, cardExpiration);
        }


        private void AddOrderStartedDomainEvent(string userName, int cardTypeId, string cardNumber,
                string cardSecurityNumber, string cardHolderName, DateTime cardExpiration)
        {
            var orderStartedDomainEvent = new OrderStartedDomainEvent(this, userName, cardTypeId,
                                                                      cardNumber, cardSecurityNumber,
                                                                      cardHolderName, cardExpiration);

            this.AddDomainEvent(orderStartedDomainEvent);
        }

        public void AddOrderItem(int productId, string productName, decimal unitPrice, string pictureUrl, int units = 1)
        {
            // orderItem validations

            var orderItem = new OrderItem(productId, productName, unitPrice, pictureUrl, units);
            _orderItems.Add(orderItem);
        }

        public void SetBuyerId(Guid buyerId)
        {
            BuyerId = buyerId;
        }

        public void SetPaymentMethodId(Guid paymentMethodId)
        {
            PaymentMethodId = paymentMethodId;
        }
    }
}
