using E_Commerce.OrderService.Application.Features.Orders.Dtos;
using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Domain.Models;
using MediatR;

namespace E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder
{
    public class CreateOrderCommand : IRequest<bool>
    {
        private readonly List<OrderItemDTO> _orderItems;
        public string UserId { get; private set; }
        public string UserName { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public CreditCardInformation CreditCardInformation { get; private set; }
        public int CardTypeId { get; private set; }
        public decimal OrderAmount { get; private set; }
        public IEnumerable<OrderItemDTO> OrderItems => _orderItems;
        public CreateOrderCommand()
        {
            _orderItems = new List<OrderItemDTO>();
        }
        public CreateOrderCommand(List<BasketItem> basketItems, decimal orderAmount, string userId, string userName, string city, string street, string state, string country, string zipcode,
           CreditCardInformation creditCardInformation, int cardTypeId) : this()
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
            UserId = userId;
            UserName = userName;
            City = city;
            Street = street;
            CardTypeId = cardTypeId;
            State = state;
            Country = country;
            ZipCode = zipcode;
            CreditCardInformation = creditCardInformation;
        }
    }


}
