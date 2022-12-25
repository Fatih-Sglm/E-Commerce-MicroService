using AutoMapper;
using E_Commerce.CatalogService.Application.Features.CatalogBrands.Dtos;
using E_Commerce.CatalogService.Domain.Entities;

namespace E_Commerce.CatalogService.Application.Features.CatalogBrands.Profiles
{
    public class CatalogBrandsProfile : Profile
    {
        public CatalogBrandsProfile()
        {
            CreateMap<CatalogBrand, GetBrandDto>();
        }
    }
}
