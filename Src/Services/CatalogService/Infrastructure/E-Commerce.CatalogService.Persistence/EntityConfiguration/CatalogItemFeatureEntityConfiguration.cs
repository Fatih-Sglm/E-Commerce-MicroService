using E_Commerce.CatalogService.Domain.Entity;
using E_Commerce.CatalogService.Domain.enums;
using E_Commerce.CatalogService.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.CatalogService.Persistence.EntityConfiguration
{
    public class CatalogItemFeatureEntityConfiguration : IEntityTypeConfiguration<CatalogItemFeature>
    {
        public void Configure(EntityTypeBuilder<CatalogItemFeature> builder)
        {
            builder.ToTable("Catalog_Item_Feature", CatalogContext.DEFAULT_SCHEMA);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);

            builder.Property(x => x.AvailableStock).IsRequired();
            builder.Property(x => x.BodySize).IsRequired(false);
            builder.Property(x => x.Genders).IsRequired();
            builder.Property(x => x.Size).IsRequired(false);
            builder.HasOne(x => x.CatalogItem).WithOne(x => x.CatalogItemFeature).HasForeignKey<CatalogItemFeature>(x => x.CatalogItemId);

            CatalogItemFeature[] catalogItemFeatures = new[] { new CatalogItemFeature()
            {
            Id =  1,
            CreatedDate = DateTime.Now,
            AvailableStock = 100,
            Size = "43",
            CatalogItemId = 1,
            Genders = Genders.Unisex,
            } ,

            new CatalogItemFeature()
            {
            Id =  2,
            CreatedDate = DateTime.Now,
            AvailableStock = 100,
            BodySize = BodySize.M,
            CatalogItemId = 2,
            Genders = Genders.Male,
            },

            new CatalogItemFeature()
            {
            Id =  3,
            CreatedDate = DateTime.Now,
            AvailableStock = 50,
            BodySize = BodySize.L,
            CatalogItemId = 3,
            Genders = Genders.Unisex,
            }};

            builder.HasData(catalogItemFeatures);
        }

    }
}
