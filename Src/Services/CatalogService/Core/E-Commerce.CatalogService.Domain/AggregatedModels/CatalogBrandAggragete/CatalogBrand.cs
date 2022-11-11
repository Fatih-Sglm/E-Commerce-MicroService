using E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate;
using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogBrandAggragete
{
    public class CatalogBrand : BaseEntity<uint>
    {
        public string Brand { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }
    }
}
