using E_Commerce.BasketService.Domain.Models;

namespace E_Commerce.BasketService.Application.Abstractions.Repository
{
    public interface IBasketRepository
    {
        Task<CustomerBasket?> GetBasketAsync(string customerId);
        IEnumerable<string> GetUsers();
        Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket customerBasket);
        Task<bool> DeleteBasketAsync(string id);
    }
}
