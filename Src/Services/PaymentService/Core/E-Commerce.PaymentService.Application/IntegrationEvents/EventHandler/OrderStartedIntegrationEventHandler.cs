using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.EventBus.Base.Events;
using E_Commerce.PaymentService.Application.Enums;
using E_Commerce.PaymentService.Application.IntegrationEvents.Events;
using E_Commerce.PaymentService.Application.Services;
using Microsoft.Extensions.Logging;

namespace E_Commerce.PaymentService.Application.IntegrationEvents.EventHandler
{
    public class OrderStartedIntegrationEventHandler : IIntegrationEventHandler<OrderStartedIntegrationEvent>
    {
        private readonly IEventBus _eventBus;
        private readonly ILogger<OrderStartedIntegrationEventHandler> _logger;
        private readonly IPaymentService _paymentService;

        public OrderStartedIntegrationEventHandler(IEventBus eventBus, ILogger<OrderStartedIntegrationEventHandler> logger, IPaymentService paymentService)
        {
            _eventBus = eventBus;
            _logger = logger;
            _paymentService = paymentService;
        }

        public async Task HandleAsync(OrderStartedIntegrationEvent @event)
        {
            bool payment = await _paymentService.Payment(@event.CreditCardInformation);

            IntegrationEvent paymentevent = payment ? new OrderPaymentSuccesIntegrationEvent(@event.OrderId, @event.UserName)
                : new OrderPaymentFailedIntegrationEvent(@event.OrderId, @event.UserName, "Error");


            IntegrationEvent orderStatusEvent = payment ? new OrderStatusChangedIntegrationEvent(@event.OrderId, OrderStatus.Paid.ToString()) :
                new OrderStatusChangedIntegrationEvent(@event.OrderId, OrderStatus.AwaitingPayment.ToString());


            _logger.LogInformation($"OrderStartedIntegrationEventHandler in " +
                $"Payment service is fired with paymentsucces:{payment} , orderId: {@event.OrderId}");

            _eventBus.Publish(paymentevent);
            _eventBus.Publish(orderStatusEvent);
        }
    }
}
