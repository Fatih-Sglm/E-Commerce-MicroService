using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.NotificationService.IntegrationEvet.Event;
using Microsoft.Extensions.Logging;

namespace E_Commerce.NotificationService.IntegrationEvet.EventHandler
{
    public class OrderPaymentSuccesIntegrationEventHandler : IIntegrationEventHandler<OrderPaymentSuccesIntegrationEvent>
    {
        private readonly ILogger<OrderPaymentSuccesIntegrationEventHandler> _logger;

        public OrderPaymentSuccesIntegrationEventHandler(ILogger<OrderPaymentSuccesIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public Task HandleAsync(OrderPaymentSuccesIntegrationEvent @event)
        {
            //todo send e-mail , sms or notification
            _logger.LogInformation($"{@event.OrderId} Id'li Siparşin Ödemesi Başarılı");
            return Task.CompletedTask;
        }
    }
}
