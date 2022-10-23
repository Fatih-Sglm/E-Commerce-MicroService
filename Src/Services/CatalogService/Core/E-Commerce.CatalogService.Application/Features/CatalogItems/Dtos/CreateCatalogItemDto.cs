using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class CreateCatalogItemDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ushort CatalogBrandId { get; set; }
        public ushort CatalogTypeId { get; set; }
        public IList<IFormFile>? ImagesPath { get; set; }
    }
}
