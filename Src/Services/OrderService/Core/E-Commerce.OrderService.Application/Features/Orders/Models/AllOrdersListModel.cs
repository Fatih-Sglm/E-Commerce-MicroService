using E_Commerce.OrderService.Application.Features.Orders.Dtos;
using E_Commerce.OrderService.Application.Paging;

namespace E_Commerce.OrderService.Application.Features.Orders.Models
{
    public class AllOrdersListModel : BasePageableModel
    {
        public List<GetOrderList> Items { get; set; }
    }
}
