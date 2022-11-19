using E_Commerce.OrderService.Application.Features.Orders.Models;

namespace E_Commerce.OrderService.Application.Features.Orders.Dtos
{
    public class GetUserOrderList
    {
        public Guid Id { get; init; }
        public string OrderDate { get; init; }
        public string OrderStatus { get; init; }
        public string? PaymentMethod { get; init; }
        public decimal OrderAmount { get; init; }
        public List<Orderitem> OrderItems { get; init; }
    }
}
