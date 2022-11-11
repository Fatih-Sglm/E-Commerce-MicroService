using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace E_Commerce.CatalogService.Persistence.Context
{
    public class CatalogContext : DbContext
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DEFAULT_SCHEMA);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
