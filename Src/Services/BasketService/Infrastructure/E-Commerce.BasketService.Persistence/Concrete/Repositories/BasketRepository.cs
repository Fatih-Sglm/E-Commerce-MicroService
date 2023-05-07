using E_Commerce.BasketService.Application.Abstractions.Configuration;
using E_Commerce.BasketService.Application.Abstractions.Repository;
using E_Commerce.BasketService.Domain.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StackExchange.Redis;
using StackExchange.Redis.Extensions.Core.Abstractions;

namespace E_Commerce.BasketService.Persistence.Concrete.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly ILogger<BasketRepository> _logger;
        private readonly IDatabase _database;
        public BasketRepository(IRedisDatabase redisDatabase, ILogger<BasketRepository> logger)
        {
            _database = redisDatabase.Database;
            _logger = logger;
        }

        public async Task DeleteBasketAsync(string id)
        {
            _ = await _database.KeyDeleteAsync(id) ? Task.CompletedTask : throw new Exception("Sepetinizde böyle bir ürün yok");
        }

        public async Task DeleteBasketItemAsync(string buyerUserName, string id)
        {
            var basketkey = await _database.StringGetAsync(buyerUserName);
            var basket = JsonConvert.DeserializeObject<CustomerBasket>(basketkey);
            if (basket is not null)
            {
                BasketItem? basketItem = basket.Items.FirstOrDefault(x => x.Id == Guid.Parse(id));
                basket.Items.Remove(basketItem);
                await UpdateBasketAsync(basket);
            }
            return;

        }
        public async Task<CustomerBasket?> GetBasketAsync(string buyerUserName)
        {
            return await GetBasketWithKey(buyerUserName);
        }

        private async Task<CustomerBasket?> GetBasketWithKey(string buyerUserName)
        {
            var basket = await _database.StringGetAsync(buyerUserName);
            return !basket.IsNullOrEmpty ? JsonConvert.DeserializeObject<CustomerBasket>(basket) : null;
        }

        //public IEnumerable<string> GetUsers()
        //{
        //    return _server.Keys().Select(x => x.ToString());
        //}

        public async Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket customerBasket)
        {
            await _database.StringSetAsync(customerBasket.BuyerUserName, JsonConvert.SerializeObject(customerBasket));
            //if (!created)
            //{
            //    _logger.LogError("Ürün Sepete eklenirken bir hata ile karşılaşıldı");
            //    return null;
            //}
            //_logger.LogInformation("Ürün Sepete Eklendi");
            return await GetBasketAsync(customerBasket.BuyerUserName);

        }
    }
}
