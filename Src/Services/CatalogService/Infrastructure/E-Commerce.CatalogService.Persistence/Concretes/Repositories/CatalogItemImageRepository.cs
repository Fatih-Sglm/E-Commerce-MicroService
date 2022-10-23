using E_Commerce.CatalogService.Application.Abstractions.Repositories;
using E_Commerce.CatalogService.Domain.Entity;
using E_Commerce.CatalogService.Persistence.Concretes.Repositories.GenericRepo;
using E_Commerce.CatalogService.Persistence.Context;

namespace E_Commerce.CatalogService.Persistence.Concretes.Repositories
{
    public class CatalogItemImageRepository : GenericRepoitory<CatalogItemImage, CatalogContext>, ICatalogItemImageRepoitory
    {
        public CatalogItemImageRepository(CatalogContext context) : base(context)
        {
        }
    }
}
