using E_Commerce.CatalogService.Domain.Entities.Common;

namespace E_Commerce.CatalogService.Domain.Entities
{
    public class CatalogItemVariant : BaseEntity<uint>
    {
        public string VariantName { get; set; }
        public string? VariantDescription { get; set; }
        public ICollection<CatalogItem>? CatalogItems { get; set; }
    }
}
