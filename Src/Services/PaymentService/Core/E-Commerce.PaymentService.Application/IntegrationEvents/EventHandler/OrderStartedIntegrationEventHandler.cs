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
            var payment = await _paymentService.Payment(new(@event.Name, @event.Email, "USD", @event.Amount, @event.CreditCard), default);

            IntegrationEvent paymentevent = payment.IsPaid ? new OrderPaymentSuccesIntegrationEvent(@event.OrderId, @event.Name, @event.Email, @event.OrderNumber, @event.OrderDate)
                : new OrderPaymentFailedIntegrationEvent(@event.OrderId, @event.Name, @event.Email, @event.OrderNumber, "Error", @event.OrderDate);


            IntegrationEvent orderStatusEvent = payment.IsPaid ? new OrderStatusChangedIntegrationEvent(@event.OrderId, OrderStatus.Paid.ToString()) :
                new OrderStatusChangedIntegrationEvent(@event.OrderId, OrderStatus.AwaitingPayment.ToString());


            _logger.LogInformation($"OrderStartedIntegrationEventHandler in " +
                $"Payment service is fired with paymentsucces:{payment.IsPaid} , orderId: {@event.OrderId}");

            _eventBus.Publish(paymentevent);
            _eventBus.Publish(orderStatusEvent);
        }
    }
}
