using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogItemImageService
    {
        Task CreateCatalogItemImage(uint catalogItemId, IFormFileCollection files);
        List<string> GetCatalogItemImage(CatalogItemImage[] catalogItemImages);
    }
}
