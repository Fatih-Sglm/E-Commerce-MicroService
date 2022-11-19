using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using MediatR;
using Microsoft.Extensions.Logging;

namespace E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEventBus _eventBus;
        private readonly ILogger<CreateOrderCommandHandler> _logger;


        public CreateOrderCommandHandler(IOrderRepository orderRepository, IEventBus eventBus,
            ILogger<CreateOrderCommandHandler> logger)
        {
            _orderRepository = orderRepository;
            _eventBus = eventBus;
            _logger = logger;
        }

        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("CreateOrderCommandHandler -> Handle method invoked");

            Address addr = new(request.Street, request.City, request.State, request.Country, request.ZipCode);

            Order dbOrder = new(request.UserName,
                addr, request.CreditCardInformation, request.CardTypeId, request.OrderAmount, null);

            foreach (var orderItem in request.OrderItems)
            {
                dbOrder.AddOrderItem(orderItem.ProductId, orderItem.ProductName, orderItem.UnitPrice, orderItem.PictureUrl, orderItem.Quantity);
            }

            await _orderRepository.AddAsync(dbOrder);
            await _orderRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            _logger.LogInformation("CreateOrderCommandHandler -> dbOrder saved");

            var orderStartedIntegrationEvent = new OrderStartedIntegrationEvent(request.UserName, dbOrder.Id);

            _eventBus.Publish(orderStartedIntegrationEvent);

            _logger.LogInformation("CreateOrderCommandHandler -> OrderStartedIntegrationEvent fired");

            return true;
        }
    }
}
