using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using E_Commerce.OrderService.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.OrderService.Application.Features.Orders.Command.PaymentOrder
{
    public class PaymentOrderCommand : IRequest<bool>
    {
        public Guid OrderId { get; set; }
        public CreditCard CreditCard { get; set; }
        public class PaymentOrderCommandHandler : IRequestHandler<PaymentOrderCommand, bool>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IEventBus _eventBus;
            public PaymentOrderCommandHandler(IOrderRepository orderRepository, IEventBus eventBus)
            {
                _orderRepository = orderRepository;
                _eventBus = eventBus;
            }

            public async Task<bool> Handle(PaymentOrderCommand request, CancellationToken cancellationToken)
            {
                Order? order = await _orderRepository.GetAsync(x => x.Id == request.OrderId, c => c.Include(x => x.Buyer), cancellationToken: cancellationToken);
                if (order is null || order.OrderStatus != OrderStatus.AwaitingPayment)
                    throw new Exception("Böyle bir siprarişniz bulunmamaktadır");
                OrderStartedIntegrationEvent paymentEvent = new(request.CreditCard, order.Buyer.UserName, order.Buyer.Fullname, order.Buyer.Email, order.Id, order.OrderDate, order.OrderAmount);
                _eventBus.Publish(paymentEvent);
                return true;
            }
        }
    }
}
