using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate
{
    public class CatalogItemImage : BaseEntity<uint>
    {
        public string? PictureFileName { get; private set; }
        public string? FolderName { get; private set; }
        public bool IsHeader { get; private set; } = false;

        public CatalogItemImage(string? pictureFileName, string? folderName)
        {
            PictureFileName = pictureFileName;
            FolderName = folderName;
        }
    }
}
