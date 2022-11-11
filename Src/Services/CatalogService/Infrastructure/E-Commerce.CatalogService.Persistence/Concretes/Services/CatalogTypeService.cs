using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogCategory.Dto;
using E_Commerce.CatalogService.Application.Features.CatalogCategory.Rule;
using E_Commerce.CatalogService.Domain.Entity;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    internal class CatalogTypeService : ICatalogTypeService
    {
        private ICatalogTypeRepository _catalogTypeRepository;
        private readonly CatalogTypeBusinessRules _catalogTypeBusinessRules;

        public CatalogTypeService(ICatalogTypeRepository catalogTypeRepository, CatalogTypeBusinessRules catalogTypeBusinessRules)
        {
            _catalogTypeRepository = catalogTypeRepository;
            _catalogTypeBusinessRules = catalogTypeBusinessRules;
        }

        public async Task<GetCatalogTypeDto> GetCategoryById(uint id)
        {
            CatalogType? catalogType = await _catalogTypeRepository.GetAsync(x => x.Id == id);
            await _catalogTypeBusinessRules.CannotNull(catalogType, "");
            return new()
            {
                Id = catalogType.Id,
                Type = catalogType.Type
            };
        }
    }
}
