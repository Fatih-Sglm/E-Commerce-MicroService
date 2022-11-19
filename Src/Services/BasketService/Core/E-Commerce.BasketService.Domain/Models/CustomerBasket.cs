namespace E_Commerce.BasketService.Domain.Models
{
    public class CustomerBasket
    {

        public string BuyerId { get; private set; }
        public string BuyerName { get; private set; }
        public List<BasketItem> Items { get; private set; } = new List<BasketItem>();

        public decimal TotalPrice => ToltalPrices(Items);
        private static decimal ToltalPrices(List<BasketItem> items)
        {
            return items.Select(x => x.UnitPrice * x.Quantity).Sum();
        }
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
