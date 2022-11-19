using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogTypes.Dto;
using E_Commerce.CatalogService.Application.Features.CatalogTypes.Rule;
using E_Commerce.CatalogService.Domain.Entities;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    internal class CatalogTypeService : ICatalogTypeService
    {
        private ICatalogTypeRepository _catalogTypeRepository;

        public CatalogTypeService(ICatalogTypeRepository catalogTypeRepository)
        {
            _catalogTypeRepository = catalogTypeRepository;
        }

        public async Task<GetCatalogTypeDto> GetCategoryById(uint id)
        {
            CatalogType? catalogType = await _catalogTypeRepository.GetAsync(x => x.Id == id);
            await catalogType.CannotNull("");
            return new()
            {
                Id = catalogType.Id,
                Type = catalogType.Name
            };
        }
    }
}
