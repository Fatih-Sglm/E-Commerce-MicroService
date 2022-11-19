namespace E_Commerce.OrderService.Application.Features.Orders.Models
{
    public class Orderitem
    {
        public string ProductName { get; init; }

        public decimal UnitPrice { get; init; }

        public uint Quantity { get; init; }

        public string PictureUrl { get; init; }
    }
}
