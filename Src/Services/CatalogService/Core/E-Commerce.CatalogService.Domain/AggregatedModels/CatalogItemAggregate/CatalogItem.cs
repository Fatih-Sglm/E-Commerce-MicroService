using E_Commerce.CatalogService.Domain.AggregatedModels.CatalogBrandAggragete;
using E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemTypeAggreagate;
using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate
{
    public class CatalogItem : BaseEntity<uint>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public CatalogBrand CatalogBrand { get; private set; }
        public uint CatalogBrandId { get; private set; }
        public CatalogType CatalogType { get; private set; }
        public uint CatalogTypeId { get; private set; }

        private readonly List<CatalogItemFeature>? _catalogItemFeatures;
        public ICollection<CatalogItemFeature>? CatalogItemFeatures => _catalogItemFeatures?.AsReadOnly();

        private readonly List<CatalogItemImage>? _catalogItemImages;
        public ICollection<CatalogItemImage>? CatalogItemImages => _catalogItemImages?.AsReadOnly();

        public CatalogItem()
        {
            _catalogItemFeatures = new List<CatalogItemFeature>();
            _catalogItemFeatures = new List<CatalogItemFeature>();
        }

        public CatalogItem(string name, string description, decimal price, uint catalogBrandId, uint catalogTypeId)
        {
            Name = name;
            Description = description;
            Price = price;
            CatalogBrandId = catalogBrandId;
            CatalogTypeId = catalogTypeId;
        }

        public void AddCatalogItemFeatures(int gendersId, int? bodySizeId, string? size, uint availableStock)
        {
            // orderItem validations
            CatalogItemFeature catalogItemFeature = new(gendersId, bodySizeId, size, availableStock);
            _catalogItemFeatures.Add(catalogItemFeature);
        }

        public void AddCatalogItemImage(string? pictureFileName, string? folderName, bool isHeader = false)
        {
            // orderItem validations
            CatalogItemImage catalogItemImage = new(pictureFileName, folderName);
            _catalogItemImages.Add(catalogItemImage);
        }


    }
}
