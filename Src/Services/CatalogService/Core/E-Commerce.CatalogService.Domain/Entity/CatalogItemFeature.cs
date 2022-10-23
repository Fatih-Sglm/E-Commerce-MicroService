using E_Commerce.CatalogService.Domain.Entity.Base;
using E_Commerce.CatalogService.Domain.enums;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogItemFeature : BaseEntity<int>
    {
        public Genders Genders { get; set; }
        public BodySize? BodySize { get; set; }
        public string? Size { get; set; }
        public int AvailableStock { get; set; }
        public CatalogItem CatalogItem { get; set; }
        public int CatalogItemId { get; set; }
    }
}
