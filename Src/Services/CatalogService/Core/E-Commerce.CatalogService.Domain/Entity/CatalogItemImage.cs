using E_Commerce.CatalogService.Domain.Entity.Base;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogItemImage : BaseEntity<int>
    {
        public string? PictureFileName { get; set; }
        public string? PictureUrl { get; set; }
        public CatalogItem? CatalogItem { get; set; }
        public int CatalogItemId { get; set; }
        public bool IsHeader { get; set; } = false;
    }
}
