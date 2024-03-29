﻿using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.EventBus.Base;
using E_Commerce.EventBus.Factory;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Application.IntegrationEvents.EventsHandlers;

namespace E_Commerce.OrderService.Api.Extensions
{
    public static class EventBusRegistration
    {
        public static void ConfigureEventHandlers(this IServiceCollection services)
        {
            services.AddTransient<OrderCreatedIntegrationEventHandler>();
            services.AddTransient<OrderStatusChangedIntegrationEventIntegrationEventHandler>();
        }
        public static IEventBus EventBusRegister(this IServiceProvider provider)
        {
            EventBusConfig config = new()
            {
                ConnectionRetryCount = 5,
                EventNameSuffix = "IntegrationEvent",
                SubscriberClientAppName = "OrderService",
                EventBusType = EventBusType.RabbitMQ,
            };
            return EventBusFactory.Create(config, provider);
        }
        public static void EventConfig(this WebApplication application)
        {
            var eventbus = application.Services.GetRequiredService<IEventBus>();
            eventbus.Subscribe<OrderCreatedIntegrationEvent, OrderCreatedIntegrationEventHandler>();
            eventbus.Subscribe<OrderStatusChangedIntegrationEvent, OrderStatusChangedIntegrationEventIntegrationEventHandler>();
        }
    }
}
