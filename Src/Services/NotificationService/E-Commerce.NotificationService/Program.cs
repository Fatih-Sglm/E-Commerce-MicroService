using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;
using E_Commerce.NotificationService.IntegrationEvet.Event;
using E_Commerce.NotificationService.IntegrationEvet.EventHandler;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

internal class Program
{

    private static void Main(string[] args)
    {
        ServiceCollection services = new();
        ConfigureService(services);

        var sp = services.BuildServiceProvider();
        IEventBus eventBus = sp.GetRequiredService<IEventBus>();

        eventBus.Subscribe<OrderPaymentSuccesIntegrationEvent, OrderPaymentSuccesIntegrationEventHandler>();
        eventBus.Subscribe<OrderPaymentFailedIntegrationEvent, OrderPaymentFailedIntegrationEventHandler>();
        Console.WriteLine("App run");
        Console.ReadLine();
    }


    private static void ConfigureService(ServiceCollection services)
    {
        services.AddLogging(cfg => cfg.AddConsole());

        services.AddTransient<OrderPaymentFailedIntegrationEventHandler>();
        services.AddTransient<OrderPaymentSuccesIntegrationEventHandler>();


        services.AddSingleton(sp =>
        {
            EventBusConfig eventBusConfig = new()
            {
                ConnectionRetryCount = 5,
                EventNameSuffix = "IntegrationEvent",
                SubscriberClientAppName = "NotificationService",
                EventBusType = EventBusType.RabbitMQ
            };
            return EventBusFactory.Create(eventBusConfig, sp);
        });

    }
}