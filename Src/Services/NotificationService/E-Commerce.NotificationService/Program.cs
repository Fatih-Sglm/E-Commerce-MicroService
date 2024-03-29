﻿using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;
using E_Commerce.NotificationService.IntegrationEvet.Event;
using E_Commerce.NotificationService.IntegrationEvet.EventHandler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;


ServiceCollection services = new();
ConfigureService(services);
BuilConfiguration(services);

var sp = services.BuildServiceProvider();

IEventBus eventBus = sp.GetRequiredService<IEventBus>();

eventBus.Subscribe<OrderPaymentSuccesIntegrationEvent, OrderPaymentSuccesIntegrationEventHandler>();
eventBus.Subscribe<OrderPaymentFailedIntegrationEvent, OrderPaymentFailedIntegrationEventHandler>();
eventBus.Subscribe<UserNotificationIntegrationEvent, UserNotificationIntegrationEventHandler>();

Console.WriteLine("App run");

while (true)
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.Key == ConsoleKey.Q && keyInfo.Modifiers ==(ConsoleModifiers.Control | ConsoleModifiers.Shift))
    {
        break;
    }
}


void ConfigureService(ServiceCollection services)
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
void BuilConfiguration(IServiceCollection services)
{
    var configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName).
          AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).AddEnvironmentVariables()
          .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
          .Build();

    services.AddSingleton<IConfiguration>(configuration);
}
