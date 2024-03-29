﻿namespace E_Commerce.OrderService.Application.Features.Orders.Models
{
    public class OrderDetailModel
    {
        public string Ordernumber { get; init; }
        public string OrderDate { get; init; }
        public string Status { get; init; }
        public string Description { get; init; }
        public string Street { get; init; }
        public string City { get; init; }
        public string Zipcode { get; init; }
        public string Country { get; init; }
        public List<Orderitem> Orderitems { get; set; }
        public decimal OrderAmount { get; set; }
    }
}
