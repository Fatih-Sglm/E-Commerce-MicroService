namespace E_Commerce.OrderService.Domain.Models
{
    public class CustomerBasket
    {
        public string BuyerId { get; set; }
        public string BuyerName { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();

        public decimal TotalPrice { get; set; }
        public CustomerBasket()
        {

        }
        public CustomerBasket(string buyerId, string buyerName)
        {
            BuyerId = buyerId;
            BuyerName = buyerName;
        }
    }
}
