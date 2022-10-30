using AutoMapper;
using E_Commerce.OrderService.Application.Features.Order.Command.CreateOrder;
using E_Commerce.OrderService.Application.Features.Order.Dtos;
using E_Commerce.OrderService.Application.Features.Order.Models;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using Ord = E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate.Order;

namespace E_Commerce.OrderService.Application.Features.Order.Profiles
{
    public class OrderProfiles : Profile
    {
        public OrderProfiles()
        {
            CreateMap<CreateOrderCommand, Ord>();
            CreateMap<OrderItemDTO, OrderItem>();

            CreateMap<Ord, OrderDetailModel>()
                .ForMember(x => x.City, y => y.MapFrom(z => z.Address.City))
                .ForMember(x => x.Country, y => y.MapFrom(z => z.Address.Country))
                .ForMember(x => x.Street, y => y.MapFrom(z => z.Address.Street))
                .ForMember(x => x.Zipcode, y => y.MapFrom(z => z.Address.ZipCode))
                .ForMember(x => x.Date, y => y.MapFrom(z => z.OrderDate))
                .ForMember(x => x.Ordernumber, y => y.MapFrom(z => z.Id.ToString()))
                .ForMember(x => x.Status, y => y.MapFrom(z => z.OrderStatus.Name))
                .ForMember(x => x.Total, y => y.MapFrom(z => z.OrderItems.Sum(i => i.Units * i.UnitPrice)))
                .ReverseMap();

            CreateMap<OrderItem, Orderitem>();
        }
    }
}
