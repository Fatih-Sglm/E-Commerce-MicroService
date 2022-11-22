using StackExchange.Redis;

namespace E_Commerce.BasketService.Api.Extensions
{
    public static class RedisConfigurationExtension
    {
        public static ConnectionMultiplexer RegisConfiguration(this IServiceProvider services, IConfiguration configuration)
        {
            var redisConfig = ConfigurationOptions.Parse(configuration["Redis:ConnectionString"], true);
            redisConfig.ResolveDns = true;
            return ConnectionMultiplexer.Connect(redisConfig);
        }
    }
}
