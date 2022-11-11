using E_Commerce.CatalogService.Domain.Entity.Base;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogItem : BaseEntity<uint>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public CatalogItemFeature CatalogItemFeature { get; set; }
        public CatalogBrand CatalogBrand { get; set; }
        public uint CatalogBrandId { get; set; }
        public CatalogType CatalogType { get; set; }
        public uint CatalogTypeId { get; set; }

        public ICollection<CatalogItemImage> CatalogItemImages { get; set; }

    }
}
