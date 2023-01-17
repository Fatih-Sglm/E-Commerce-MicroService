﻿using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Domain.Events;
using E_Commerce.OrderService.Domain.Models;
using E_Commerce.OrderService.Domain.SeedWork;

namespace E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate
{
    public class Order : BaseEntity, IAggregateRoot
    {
        public string? Description { get; private set; }
        public string OrderNumber { get; private set; }
        public Guid? BuyerId { get; private set; }
        public Buyer Buyer { get; private set; }
        public Address Address { get; private set; }
        private int orderStatusId;
        public OrderStatus OrderStatus { get; set; }
        private readonly List<OrderItem> _orderItems;
        public IEnumerable<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public Guid? PaymentMethodId { get; private set; }
        public double OrderAmount { get; private set; }
        public DateTime OrderDate { get => base.CreateDate; set => base.CreateDate = value; }

        protected Order()
        {
            Id = Guid.NewGuid();
            _orderItems = new List<OrderItem>();
        }

        public Order(string userName, string fullName, string mail, Address address, string alias, CreditCard creditCard, int cardTypeId, OrderStatus orderStatus, double orderAmount, bool willPaymentRecord) : this()
        {
            orderStatusId = orderStatus.Id;
            Address = address;
            OrderAmount = orderAmount;
            OrderNumber = string.Concat(userName[..3], Guid.NewGuid().ToString("d"));
            AddOrderStartedDomainEvent(userName, fullName, mail, cardTypeId, alias, creditCard, willPaymentRecord);
        }


        private void AddOrderStartedDomainEvent(string userName, string fullName, string email, int cardTypeId, string alias, CreditCard creditCard, bool willPaymentRecord)
        {
            var orderStartedDomainEvent = new OrderStartedDomainEvent(this, userName, fullName, email, cardTypeId, alias, creditCard, willPaymentRecord);

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

        public void SetOrderStatus(OrderStatus orderStatus)
        {
            orderStatusId = orderStatus.Id;
        }

        public void SetPaymentMethodId(Guid? paymentMethodId)
        {
            PaymentMethodId = paymentMethodId;
        }
    }
}
