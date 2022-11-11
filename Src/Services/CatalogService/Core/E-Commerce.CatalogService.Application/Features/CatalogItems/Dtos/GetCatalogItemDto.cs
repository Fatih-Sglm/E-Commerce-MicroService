namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class GetCatalogItemDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CatalogBrandName { get; set; }
        public string CatalogTypeName { get; set; }
        public IList<string> CatalogItemsImagesPath { get; set; }
        public string Genders { get; set; }
        public string? BodySize { get; set; }
        public string? Size { get; set; }
        public uint AvailableStock { get; set; }
    }
}
