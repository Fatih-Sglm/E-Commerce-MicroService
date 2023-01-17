﻿namespace E_Commerce.BasketService.Domain.Models
{
    public class CustomerBasket
    {
        public string BuyerUserName { get; set; }

        public List<BasketItem> Items { get; set; } = new List<BasketItem>();

        public double TotalPrice => ToltalPrices(Items);
        private static double ToltalPrices(List<BasketItem> items)
        {
            return items.Select(x => x.UnitPrice * x.Quantity).Sum();
        }
        public CustomerBasket()
        {

        }

        public CustomerBasket(string buyerUserName)
        {
            BuyerUserName = buyerUserName;
        }
    }
}
