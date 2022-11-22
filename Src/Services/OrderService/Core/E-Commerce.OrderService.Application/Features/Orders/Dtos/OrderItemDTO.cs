namespace E_Commerce.OrderService.Application.Features.Orders.Dtos
{
    public class OrderItemDTO
    {
        public uint ProductId { get; init; }

        public string ProductName { get; init; }

        public decimal UnitPrice { get; init; }

        public uint Quantity { get; init; }

        public string PictureUrl { get; init; }
    }
}
