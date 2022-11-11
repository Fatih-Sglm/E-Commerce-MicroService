using E_Commerce.CatalogService.Application.Features.CatalogBrands.Dtos;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogBrandService
    {
        Task<GetBrandDto> GetBrandById(uint Id);
    }
}
