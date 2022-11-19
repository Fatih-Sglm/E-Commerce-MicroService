using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.Events;
using E_Commerce.PaymentService.Api.IntegrationEvents.Events;

namespace E_Commerce.PaymentService.Api.IntegrationEvents.EventHandler
{
    public class OrderStartedIntegrationEventHandler : IIntegrationEventHandler<OrderStartedIntegrationEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly ILogger<OrderStartedIntegrationEventHandler> _logger;

        public OrderStartedIntegrationEventHandler(IEventBus eventBus, ILogger<OrderStartedIntegrationEventHandler> logger)
        {
            _eventBus = eventBus;
            _logger = logger;
        }

        public Task HandleAsync(OrderStartedIntegrationEvent @event)
        {
            bool payment = true;

            IntegrationEvent paymentevent = payment ? new OrderPaymentSuccesIntegrationEvent(@event.OrderId) :
                new OrderPaymentFailedIntegrationEvent(@event.OrderId, "Error");

            _logger.LogInformation($"OrderStartedIntegrationEventHandler in " +
                $"Payment service is fired with paymentsucces:{payment} , orderId: {@event.OrderId}");

            _eventBus.Publish(paymentevent);
            return Task.CompletedTask;
        }
    }
}
