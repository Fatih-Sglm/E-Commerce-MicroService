namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class UpdateCatalogItemDto
    {
        public uint Id { get; set; }
        public CreateCatalogItemDto createCatalogItemDto { get; set; }
        public CreateCatalogItemFeaturesDto createCatalogItemFeaturesDto { get; set; }
    }
}
