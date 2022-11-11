using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate
{
    public class CatalogItemFeature : BaseEntity<uint>
    {
        public Genders Genders { get; set; }
        public BodySize? BodySize { get; set; }
        public string? Size { get; set; }
        public uint AvailableStock { get; set; }

        public CatalogItemFeature(int gendersId, int? bodySizeId, string? size, uint availableStock)
        {
            Genders = Enumeration.FromValue<Genders>(gendersId);
            BodySize = Enumeration.FromValue<BodySize>(bodySizeId);
            Size = size;
            AvailableStock = availableStock;
        }
    }
}
