using E_Commerce.CatalogService.Domain.enums;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class CreateCatalogItemFeaturesDto
    {
        public Genders Genders { get; set; }
        public BodySize? BodySize { get; set; }
        public string? Size { get; set; }
        public uint AvailableStock { get; set; }
    }
}
