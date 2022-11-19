namespace E_Commerce.OrderService.Domain.Models
{
    public class BasketItem
    {
        public string Id { get; set; }

        public uint ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal OldUnitPrice { get; set; }

        public uint Quantity { get; set; }

        public string PictureUrl { get; set; }
    }
}
