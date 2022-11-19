using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class UpdateCatalogItemDto
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public uint CatalogBrandId { get; set; }
        public uint CatalogTypeId { get; set; }
        public IFormFileCollection? ImagesPath { get; set; }

    }
}
