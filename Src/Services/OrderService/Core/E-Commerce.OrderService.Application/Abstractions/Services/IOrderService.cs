using E_Commerce.OrderService.Application.Features.Order.Command.CreateOrder;

namespace E_Commerce.OrderService.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrderCommand command);
    }
}
