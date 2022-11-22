using AutoMapper;
using E_Commerce.OrderService.Application.Features.Orders.Command.CreateOrder;
using E_Commerce.OrderService.Application.Features.Orders.Dtos;
using E_Commerce.OrderService.Application.Features.Orders.Models;
using E_Commerce.OrderService.Application.Paging;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;

namespace E_Commerce.OrderService.Application.Features.Orders.Profiles
{
    public class OrderProfiles : Profile
    {
        public OrderProfiles()
        {
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<OrderItemDTO, OrderItem>();

            CreateMap<Order, OrderDetailModel>()
                .ForMember(x => x.City, y => y.MapFrom(z => z.Address.City))
                .ForMember(x => x.Country, y => y.MapFrom(z => z.Address.Country))
                .ForMember(x => x.Street, y => y.MapFrom(z => z.Address.Street))
                .ForMember(x => x.Zipcode, y => y.MapFrom(z => z.Address.ZipCode))
                .ForMember(x => x.OrderDate, y => y.MapFrom(z => z.OrderDate.ToString("dddd, dd MMMM yyyy HH:mm")))
                .ForMember(x => x.Ordernumber, y => y.MapFrom(z => z.Id.ToString()))
                .ForMember(x => x.Status, y => y.MapFrom(z => z.OrderStatus.Name))
                .ReverseMap();


            CreateMap<Order, GetOrderList>().ForMember(x => x.OrderStatus, y => y.MapFrom(z => z.OrderStatus.Name))
                .ForMember(x => x.BuyerName, y => y.MapFrom(z => z.Buyer.Name))
                .ForMember(x => x.PaymentMethod, y => y.MapFrom(z => z.Buyer.PaymentMethods.FirstOrDefault(t => t.Id == z.PaymentMethodId)));

            CreateMap<IPaginate<Order>, UserOrderListModel>();
            CreateMap<IPaginate<Order>, AllOrdersListModel>();
            CreateMap<Order, GetUserOrderList>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(z => z.OrderStatus.Name))
                .ForMember(x => x.PaymentMethod, y => y.MapFrom(z => z.Buyer.PaymentMethods.FirstOrDefault(t => t.Id == z.PaymentMethodId)))
                .ForMember(x => x.OrderDate, y => y.MapFrom(z => z.OrderDate.ToString("dddd, dd MMMM yyyy HH:mm"))).ReverseMap();

            CreateMap<OrderItem, Orderitem>();
        }
    }
}
