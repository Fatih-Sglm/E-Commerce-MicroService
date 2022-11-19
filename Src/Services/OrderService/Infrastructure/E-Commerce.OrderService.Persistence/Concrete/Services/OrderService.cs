using E_Commerce.EventBus.Base.Abstraction;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.Abstractions.Services;
using E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder;
using E_Commerce.OrderService.Application.IntegrationEvents.Events;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using Microsoft.Extensions.Logging;

namespace E_Commerce.OrderService.Persistence.Concrete.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IEventBus _eventBus;
        private readonly ILogger<CreateOrderCommandHandler> _logger;
        private readonly IIdentityService _ıdentityService;


        public OrderService(IOrderRepository orderRepository, IEventBus eventBus, ILogger<CreateOrderCommandHandler> logger, IIdentityService ıdentityService)
        {
            _orderRepository = orderRepository;
            _eventBus = eventBus;
            _logger = logger;
            _ıdentityService = ıdentityService;
        }
        public async Task CreateOrder(CreateOrderCommand request)
        {
            Address addr = new(request.Street, request.City, request.State, request.Country, request.ZipCode);
            Order dbOrder = new(request.UserName,
            addr, request.CreditCardInformation, request.CardTypeId, request.OrderItems.Count(), request.WillPaymentRecord);
            foreach (var orderItem in request.OrderItems)
            {
                dbOrder.AddOrderItem(orderItem.ProductId, orderItem.ProductName, orderItem.UnitPrice, orderItem.PictureUrl, orderItem.Quantity);
            }

            await _orderRepository.AddAsync(dbOrder);
            await _orderRepository.UnitOfWork.SaveEntitiesAsync();

            _logger.LogInformation("CreateOrderCommandHandler -> dbOrder saved");

            (string fullname, string Email) = await _ıdentityService.GetUserInfos(request.UserName);

            var orderStartedIntegrationEvent = new OrderStartedIntegrationEvent(request.CreditCardInformation, fullname, Email, dbOrder.Id);

            _eventBus.Publish(orderStartedIntegrationEvent);

            _logger.LogInformation("CreateOrderCommandHandler -> OrderStartedIntegrationEvent fired");
        }
    }
}
