using E_Commerce.CatalogService.Domain.Entities.Common;

namespace E_Commerce.CatalogService.Domain.Entities
{
    public class CatalogItem : BaseEntity<uint>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CatalogBrand CatalogBrand { get; set; }
        public uint CatalogBrandId { get; set; }
        public CatalogType CatalogType { get; set; }
        public uint CatalogTypeId { get; set; }
        public ICollection<CatalogItemImage>? CatalogItemImages { get; set; }
        public ICollection<CatalogItemVariant>? CatalogItemVariants { get; set; }
    }
}
