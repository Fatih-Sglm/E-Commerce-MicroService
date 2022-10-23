using E_Commerce.CatalogService.Domain.Entity.Base;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogItem : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public CatalogItemFeature CatalogItemFeature { get; set; }
        public CatalogBrand CatalogBrand { get; set; }
        public ushort CatalogBrandId { get; set; }
        public CatalogType CatalogType { get; set; }
        public ushort CatalogTypeId { get; set; }

        public ICollection<CatalogItemImage> CatalogItemImages { get; set; }

    }
}
