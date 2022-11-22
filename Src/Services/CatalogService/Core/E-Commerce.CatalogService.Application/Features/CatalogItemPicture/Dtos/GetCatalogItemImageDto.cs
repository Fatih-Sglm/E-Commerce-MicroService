namespace E_Commerce.CatalogService.Application.Features.CatalogItemPicture.Dtos
{
    public class GetCatalogItemImageDto
    {
        public uint Id { get; set; }
        public string path { get; set; }

        public uint CatalogItemId { get; set; }
    }
}
