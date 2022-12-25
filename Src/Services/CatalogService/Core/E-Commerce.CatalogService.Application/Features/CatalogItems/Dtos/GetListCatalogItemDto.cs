namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class GetListCatalogItemDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CatalogBrandName { get; set; }
        public string CatalogTypeName { get; set; }
        public IList<string>? CatalogItemsHeaderImages { get; set; }
    }
}
