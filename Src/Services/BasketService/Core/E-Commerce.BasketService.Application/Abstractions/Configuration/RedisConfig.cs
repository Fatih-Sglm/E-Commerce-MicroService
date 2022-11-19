using StackExchange.Redis;

namespace E_Commerce.BasketService.Application.Abstractions.Configuration
{
    public class RedisConfig : IRedisConfig
    {
        private readonly ConnectionMultiplexer _redis;

        public RedisConfig(ConnectionMultiplexer redis)
        {
            _redis = redis;
        }

        public IDatabase GetRedisDatabase()
        {
            return _redis.GetDatabase();
        }

        public IServer GetServer()
        {
            var endpoint = _redis.GetEndPoints();
            return _redis.GetServer(endpoint.First());
        }
    }
}
