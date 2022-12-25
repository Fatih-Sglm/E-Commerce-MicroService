using E_Commerce.CatalogService.Application.Features.CatalogBrands.Dtos;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogBrandService
    {
        Task CheckBrandIsNull(uint Id);
        Task<List<GetBrandDto>> GetBrands();
    }
}
