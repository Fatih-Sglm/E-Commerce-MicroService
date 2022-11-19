using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Domain.Events;
using E_Commerce.OrderService.Domain.SeedWork;

namespace E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public string? Description { get; private set; }
        public Guid? BuyerId { get; private set; }
        public Buyer Buyer { get; private set; }
        public Address Address { get; private set; }

        private int orderStatusId;
        public OrderStatus OrderStatus { get; private set; }

        private readonly List<OrderItem> _orderItems;
        public IEnumerable<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public Guid? PaymentMethodId { get; private set; }
        public decimal OrderAmount { get; private set; }
        public DateTime OrderDate { get => base.CreateDate; set => base.CreateDate = value; }
        protected Order()
        {
            Id = Guid.NewGuid();
            _orderItems = new List<OrderItem>();
        }

        public Order(string userName, Address address, CreditCardInformation creditCardInformation, int cardTypeId, decimal orderAmount, bool willPaymentRecord) : this()
        {
            orderStatusId = OrderStatus.Submitted.Id;
            Address = address;
            OrderAmount = orderAmount;

            AddOrderStartedDomainEvent(userName, cardTypeId, creditCardInformation, willPaymentRecord);
        }


        private void AddOrderStartedDomainEvent(string userName, int cardTypeId, CreditCardInformation creditCardInformation, bool willPaymentRecord)
        {
            var orderStartedDomainEvent = new OrderStartedDomainEvent(this, userName, cardTypeId, creditCardInformation, willPaymentRecord);

            this.AddDomainEvent(orderStartedDomainEvent);
        }

        public void AddOrderItem(uint productId, string productName, decimal unitPrice, string pictureUrl, uint quantity = 1)
        {
            // orderItem validations

            var orderItem = new OrderItem(productId, productName, unitPrice, pictureUrl, quantity);
            _orderItems.Add(orderItem);
        }

        public void SetBuyerId(Guid buyerId)
        {
            BuyerId = buyerId;
        }

        public void SetPaymentMethodId(Guid? paymentMethodId)
        {
            PaymentMethodId = paymentMethodId;
        }
    }
}
