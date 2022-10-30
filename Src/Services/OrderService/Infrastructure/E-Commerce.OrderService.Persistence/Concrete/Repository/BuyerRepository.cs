using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Persistence.Concrete.Repository.GenericRepo;
using E_Commerce.OrderService.Persistence.Contexts;

namespace E_Commerce.OrderService.Persistence.Concrete.Repository
{
    public class BuyerRepository : GenericRepoitory<Buyer, OrderContext>, IBuyerRepository
    {
        public BuyerRepository(OrderContext context) : base(context)
        {
        }
    }
}
