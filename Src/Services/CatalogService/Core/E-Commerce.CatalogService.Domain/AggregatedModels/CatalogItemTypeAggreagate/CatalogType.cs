using E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate;
using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemTypeAggreagate
{
    public class CatalogType : BaseEntity<uint>
    {
        public string Type { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }
    }
}
