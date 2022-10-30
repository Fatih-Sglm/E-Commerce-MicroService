using E_Commerce.CatalogService.Domain.Entity;
using E_Commerce.CatalogService.Persistence.EntityConfiguration;
using E_Commerce.OrderService.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.CatalogService.Persistence.Context
{
    public class CatalogContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "catalog";

        public CatalogContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CatalogBrand> CatalogBrands { get; set; }

        public DbSet<CatalogType> CatalogTypes { get; set; }

        public DbSet<CatalogItem> CatalogItems { get; set; }

        public DbSet<CatalogItemFeature> CatalogItemFeatures { get; set; }

        public DbSet<CatalogItemImage> CatalogItemImages { get; set; }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CatalogBrandEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogTypeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogItemFeatureEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogItemImageEntityConfiguration());

        }
    }
}
