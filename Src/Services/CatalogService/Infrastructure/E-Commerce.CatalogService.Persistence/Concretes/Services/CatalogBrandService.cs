using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Features.CatalogBrands.Dtos;
using E_Commerce.CatalogService.Application.Features.CatalogBrands.Rules;
using E_Commerce.CatalogService.Domain.Entity;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    public class CatalogBrandService : ICatalogBrandService
    {
        private readonly ICatalogBrandRepository _catalogBrandRepository;
        private readonly CatalogBrandBusinessRules _catalogBrandBusinessRules;

        public CatalogBrandService(CatalogBrandBusinessRules catalogBrandBusinessRules, ICatalogBrandRepository catalogBrandRepository)
        {
            _catalogBrandBusinessRules = catalogBrandBusinessRules;
            _catalogBrandRepository = catalogBrandRepository;
        }

        public async Task<GetBrandDto> GetBrandById(uint Id)
        {
            CatalogBrand? catalogBrand = await _catalogBrandRepository.GetAsync(x => x.Id == Id);
            await _catalogBrandBusinessRules.CannotNull(catalogBrand, "");
            return new()
            {
                Id = catalogBrand.Id,
                Brand = catalogBrand.Brand,
            };
        }
    }
}
