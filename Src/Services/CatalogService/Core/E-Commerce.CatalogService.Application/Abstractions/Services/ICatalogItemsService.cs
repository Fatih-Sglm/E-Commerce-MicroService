using E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos;
using E_Commerce.CatalogService.Application.Features.CatalogItems.Models;
using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entity;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogItemsService
    {
        Task CreateProduct(CreateCatalogItemDto createCatalogItemDto, CreateCatalogItemFeaturesDto createCatalogItemFeaturesDto);
        Task<CatalogItem> GetByIdWithImage(int CatalogItemId);
        Task UpdateProduct(UpdateCatalogItemDto updateCatalogItemDto);

        Task<GetCatalogItemDto> GetCatalogItem(int CatalogItemId);

        Task<CatalogItemListModel> GetListCatalogItem(PageRequest pageRequest);
    }
}
