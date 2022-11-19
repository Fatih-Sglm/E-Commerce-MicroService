namespace E_Commerce.OrderService.Application.Features.Orders.Models
{
    public class Orderitem
    {
        public string Productname { get; init; }
        public int Units { get; init; }
        public double Unitprice { get; init; }
        public string Pictureurl { get; init; }
    }
}
