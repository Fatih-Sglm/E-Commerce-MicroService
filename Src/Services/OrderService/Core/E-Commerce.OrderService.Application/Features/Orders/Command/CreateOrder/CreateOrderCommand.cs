using E_Commerce.OrderService.Application.Features.Orders.Dtos;
using E_Commerce.OrderService.Domain.Models;
using MediatR;

namespace E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder
{
    public class CreateOrderCommand : IRequest<bool>
    {
        private readonly List<OrderItemDTO> _orderItems;
        public string UserName { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public string? Alias { get; set; }
        public CreditCard CreditCard { get; private set; }
        public int CardTypeId { get; private set; }
        public double OrderAmount { get; private set; }
        public bool WillPaymentRecord { get; private set; }
        public IEnumerable<OrderItemDTO> OrderItems => _orderItems;
        public CreateOrderCommand()
        {
            _orderItems = new List<OrderItemDTO>();
        }
        public CreateOrderCommand(List<BasketItem> basketItems, double orderAmount, string userName, string name, string email, string city, string street, string state, string country, string zipcode, string alias,
           CreditCard creditCard, int cardTypeId, bool willPaymentRecord) : this()
        {
            var dtoList = basketItems.Select(item => new OrderItemDTO()
            {
                ProductId = item.ProductId,
                ProductName = item.ProductName,
                PictureUrl = item.PictureUrl,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity
            }).ToList();
            OrderAmount = orderAmount;
            _orderItems = dtoList;
            Alias = alias;
            UserName = userName;
            City = city;
            Name = name;
            Email = email;
            Street = street;
            CardTypeId = cardTypeId;
            State = state;
            Country = country;
            ZipCode = zipcode;
            CreditCard = creditCard;
            WillPaymentRecord = willPaymentRecord;
        }
    }


}
