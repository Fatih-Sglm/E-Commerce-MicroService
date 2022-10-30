namespace E_Commerce.OrderService.Application.Features.Order.Dtos
{
    public class OrderItemDTO
    {
        public int ProductId { get; init; }

        public string ProductName { get; init; }

        public decimal UnitPrice { get; init; }

        public int Units { get; init; }

        public string PictureUrl { get; init; }
    }
}
