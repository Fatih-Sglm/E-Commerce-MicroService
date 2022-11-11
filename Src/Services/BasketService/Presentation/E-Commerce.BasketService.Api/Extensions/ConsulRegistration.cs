using Consul;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http.Features;

namespace E_Commerce.BasketService.Api.Extensions
{
    public static class ConsulRegistration
    {
        public static void ConfigureConsul(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(cfg =>
            {
                var adress = configuration["ConsulConfig:Adress"];
                cfg.Address = new Uri(adress);
            }));
        }

        public static void RegisterWithConsul(this IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();

            var loggingFactory = app.ApplicationServices.GetRequiredService<ILoggerFactory>();

            var logger = loggingFactory.CreateLogger<IApplicationBuilder>();


            var features = app.Properties["server.Features"] as FeatureCollection;
            var adresses = features.Get<IServerAddressesFeature>();
            var adress = adresses.Addresses.First();

            var uri = new Uri(adress);

            var registration = new AgentServiceRegistration()
            {
                ID = "BasketService",
                Name = "BasketService",
                Address = $"{uri.Host}",
                Port = uri.Port,
                Tags = new[] { "BasketService", "Basket" }
            };

            logger.LogInformation("Registering with Consul");
            consulClient.Agent.ServiceDeregister(registration.ID).Wait();
            consulClient.Agent.ServiceRegister(registration).Wait();

            lifetime.ApplicationStopping.Register(() =>
            {
                logger.LogInformation("Deregistering from Consul");
                consulClient.Agent.ServiceDeregister(registration.ID).Wait();
            });

        }
    }
}
