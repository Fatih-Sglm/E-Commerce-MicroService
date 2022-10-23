namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class GetListCatalogItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CatalogBrandName { get; set; }
        public string CatalogTypeName { get; set; }
        public IList<string> CatalogItemsHeaderImage { get; set; }
    }
}
