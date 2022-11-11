using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Application.Abstractions.Storage
{
    public interface IStorage
    {
        Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string pathOrContainerName, IFormFileCollection files);
        Task DeleteAsync(string pathOrContainerName, string fileName);
        string? GetFile(string pathOrContainerName, string fileName);
        bool HasFile(string pathOrContainerName, string fileName);
    }
}
