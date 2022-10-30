using StackExchange.Redis;

namespace E_Commerce.BasketService.Persistence.Configuration
{
    public interface IRedisConfig
    {
        IDatabase GetRedisDatabase();
        IServer GetServer();
    }
}
