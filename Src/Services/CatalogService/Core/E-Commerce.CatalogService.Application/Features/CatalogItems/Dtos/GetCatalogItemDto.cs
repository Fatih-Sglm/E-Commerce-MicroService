namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class GetCatalogItemDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CatalogBrandName { get; set; }
        public string CatalogTypeName { get; set; }
        public IList<string> CatalogItemsImagesPath { get; set; }
        public IList<string>? CatalogItemsVariants { get; set; }
    }
}
