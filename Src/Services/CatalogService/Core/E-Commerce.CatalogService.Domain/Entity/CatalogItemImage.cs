using E_Commerce.CatalogService.Domain.Entity.Base;

namespace E_Commerce.CatalogService.Domain.Entity
{
    public class CatalogItemImage : BaseEntity<uint>
    {
        public string? PictureFileName { get; set; }
        public string? FolderName { get; set; }
        public CatalogItem? CatalogItem { get; set; }
        public uint CatalogItemId { get; set; }
        public bool IsHeader { get; set; } = false;
    }
}
