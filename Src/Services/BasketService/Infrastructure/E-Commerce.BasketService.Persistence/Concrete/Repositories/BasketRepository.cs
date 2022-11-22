using E_Commerce.BasketService.Application.Abstractions.Configuration;
using E_Commerce.BasketService.Application.Abstractions.Repository;
using E_Commerce.BasketService.Domain.Models;
using E_Commerce.BasketService.Persistence.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace E_Commerce.BasketService.Persistence.Concrete.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;
        private readonly IServer _server;
        private readonly ILogger<BasketRepository> _logger;

        public BasketRepository(IRedisConfig redisConfig, ILogger<BasketRepository> logger)
        {
            _database = redisConfig.GetRedisDatabase();
            _server = redisConfig.GetServer();
            _logger = logger;
        }

        public async Task DeleteBasketAsync(string id)
        {
            _ = await _database.KeyDeleteAsync(id) ? Task.CompletedTask : throw new Exception("Sepetinizde böyle bir ürün yok");
        }

        public async Task DeleteBasketItemAsync(string buyerUserName, string id)
        {
            var basket = await _database.StringGetAsync(customerId);
            return !basket.IsNullOrEmpty ? JsonConvert.DeserializeObject<CustomerBasket>(basket) : null;
        }
        public async Task<CustomerBasket?> GetBasketAsync(string buyerUserName)
        {
            return await GetBasketWithKey(buyerUserName);
        }

        public IEnumerable<string> GetUsers()
        {
            return _server.Keys().Select(x => x.ToString());
        }

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
