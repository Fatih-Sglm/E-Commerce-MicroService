using E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder;

namespace E_Commerce.OrderService.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrderCommand command);
    }
}
