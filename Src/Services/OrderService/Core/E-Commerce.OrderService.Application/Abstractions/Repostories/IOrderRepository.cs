using E_Commerce.OrderService.Application.Abstractions.Repostories.GenericRepo;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;

namespace E_Commerce.OrderService.Application.Abstractions.Repostories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order?> GetById(Guid id);
    }
}
