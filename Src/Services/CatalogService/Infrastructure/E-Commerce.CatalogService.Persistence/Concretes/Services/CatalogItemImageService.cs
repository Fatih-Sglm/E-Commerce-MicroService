using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Application.Abstractions.Storage;
using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    public class CatalogItemImageService : ICatalogItemImageService
    {
        private readonly ICatalogItemImageRepoitory _catalogItemImageRepoitory;
        private readonly IStorage _storage;

        public CatalogItemImageService(ICatalogItemImageRepoitory catalogItemImageRepoitory, IStorage storage)
        {
            _catalogItemImageRepoitory = catalogItemImageRepoitory;
            _storage = storage;
        }

        public async Task CreateCatalogItemImage(uint catalogItemId, IFormFileCollection files)
        {
            if (files.Count > 0)
            {
                List<CatalogItemImage> catalogItems = new();
                var value = await _storage.UploadAsync("Product", files);
                foreach (var item in value)
                {

                    CatalogItemImage catalogItemImage = new()
                    {
                        CatalogItemId = catalogItemId,
                        PictureFileName = item.fileName,
                        FolderName = item.pathOrContainerName,
                    };

                    catalogItems.Add(catalogItemImage);
                }
                await _catalogItemImageRepoitory.AddRangeAsync(catalogItems);
            }
            else
                return;
        }

        public List<string> GetCatalogItemImage(CatalogItemImage[] catalogItemImages)
        {
            List<string> ImagePaths = new();

            foreach (var item in catalogItemImages)
            {
                ImagePaths.Add(_storage.GetFile(item.FolderName, item.PictureFileName));
            }
            return ImagePaths;
        }
    }
}
