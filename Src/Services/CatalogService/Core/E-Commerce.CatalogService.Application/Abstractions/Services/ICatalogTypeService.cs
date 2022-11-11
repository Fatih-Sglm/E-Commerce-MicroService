using E_Commerce.CatalogService.Application.Features.CatalogCategory.Dto;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogTypeService
    {
        Task<GetCatalogTypeDto> GetCategoryById(uint id);
    }
}
