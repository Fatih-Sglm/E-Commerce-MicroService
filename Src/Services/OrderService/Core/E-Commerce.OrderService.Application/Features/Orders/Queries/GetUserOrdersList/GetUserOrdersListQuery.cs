using AutoMapper;
using E_Commerce.OrderService.Application.Abstractions.Repostories;
using E_Commerce.OrderService.Application.Abstractions.Services;
using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Application.Models.Paging;
using E_Commerce.OrderService.Application.Models.ResponseModels;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.OrderService.Application.Features.Orders.Queries.GetUserOrdersList
{
    public class GetUserOrdersListQuery : PageRequest, IRequest<ResponseDto<UserOrderListModel>>
    {
        public string userName { get; set; }
        public class GetUserOrdersListQueryHandler : IRequestHandler<GetUserOrdersListQuery, ResponseDto<UserOrderListModel>>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IBuyerService _buyerservice;
            private readonly IMapper _mapper;
            public GetUserOrdersListQueryHandler(IOrderRepository orderRepository, IBuyerService buyerservice, IMapper mapper)
            {
                _orderRepository = orderRepository;
                _buyerservice = buyerservice;
                _mapper = mapper;
            }

            public async Task<ResponseDto<UserOrderListModel>> Handle(GetUserOrdersListQuery request, CancellationToken cancellationToken)
            {
                Guid Id = await _buyerservice.FindBuyerIdWithUserName(request.userName);

                //IQueryable<Order> value = await _orderRepository.GetListAsync(x => x.BuyerId == Id,
                //    orderBy: x => x.OrderByDescending(x => x.OrderDate),
                //    include: x => x.Include(x => x.OrderItems).Include(x => x.OrderStatus).Include(x => x.Buyer).ThenInclude(x => x.PaymentMethods),
                //    cancellationToken: cancellationToken);

                //var userOrderList = _mapper.ProjectTo<GetUserOrderList>(value);

                //var Orders = userOrderList.ToPaginate(request.Page, request.PageSize, 0);

                IPaginate<Order> Orders = await _orderRepository.GetListAsyncWithPaginate(x => x.BuyerId == Id,
                    orderBy: x => x.OrderByDescending(x => x.OrderDate),
                    include: x => x.Include(x => x.OrderItems).Include(x => x.OrderStatus).Include(x => x.Buyer).ThenInclude(x => x.PaymentMethods),
                    index: request.Page, size: request.PageSize,
                    cancellationToken: cancellationToken);

                return ResponseDto<UserOrderListModel>.SuccesWithData(_mapper.Map<UserOrderListModel>(Orders));
            }
        }
    }
}
