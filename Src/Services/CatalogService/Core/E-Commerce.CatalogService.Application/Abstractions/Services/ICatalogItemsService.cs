using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entity;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogItemsService
    {
        Task CreateProduct(CreateCatalogItemDto createCatalogItemDto, CreateCatalogItemFeaturesDto createCatalogItemFeaturesDto);
        Task<CatalogItem> GetByIdWithImage(uint CatalogItemId);
        Task UpdateProduct(UpdateCatalogItemDto updateCatalogItemDto);

        Task<GetCatalogItemDto> GetCatalogItem(uint CatalogItemId);

        Task<CatalogItemListModel> GetListCatalogItem(PageRequest pageRequest);

        Task<CatalogItemListModel?> GetListCatalogItemByType(PageRequest pageRequest, uint catalogTypeId);

        Task<CatalogItemListModel?> GetListCatalogItemByBrand(PageRequest pageRequest, uint brandId);
    }
}
