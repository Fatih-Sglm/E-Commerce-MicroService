using E_Commerce.CatalogService.Domain.Entity.Base;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogType : BaseEntity<ushort>
    {
        public string Type { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }
    }
}
