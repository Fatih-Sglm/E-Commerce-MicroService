using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogItemImageService
    {
        Task CreateCatalogItemImage(int catalogItemId, IList<IFormFile> files);
    }
}
