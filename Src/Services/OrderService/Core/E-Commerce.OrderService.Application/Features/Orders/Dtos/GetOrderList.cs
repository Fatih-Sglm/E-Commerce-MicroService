namespace E_Commerce.OrderService.Application.Features.Orders.Dtos
{
    public class GetOrderList : GetUserOrderList
    {
        public string BuyerName { get; init; }
    }
}
