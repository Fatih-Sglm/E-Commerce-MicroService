using E_Commerce.CatalogService.Domain.Entity.Base;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogBrand : BaseEntity<uint>
    {
        public string Brand { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }
    }
}
