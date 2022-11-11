using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Application.Abstractions.Services;
using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Persistence.Concretes.Services
{
    public class CatalogItemImageService : ICatalogItemImageService
    {
        private readonly ICatalogItemImageRepoitory _catalogItemImageRepoitory;

        public CatalogItemImageService(ICatalogItemImageRepoitory catalogItemImageRepoitory)
        {
            _catalogItemImageRepoitory = catalogItemImageRepoitory;
        }

        public async Task CreateCatalogItemImage(uint catalogItemId, IList<IFormFile> files)
        {
            if (files.Count > 0)
            {
                List<CatalogItemImage> catalogItems = new();
                foreach (IFormFile file in files)
                {
                    CatalogItemImage catalogItemImage = new()
                    {
                        CatalogItemId = catalogItemId,
                        PictureFileName = file.FileName,
                    };

                    catalogItems.Add(catalogItemImage);
                }

                await _catalogItemImageRepoitory.AddRangeAsync(catalogItems);
            }
            else
                return;
        }
    }
}
