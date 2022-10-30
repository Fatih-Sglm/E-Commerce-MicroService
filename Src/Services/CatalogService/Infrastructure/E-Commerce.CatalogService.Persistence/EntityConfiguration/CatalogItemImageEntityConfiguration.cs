﻿using E_Commerce.CatalogService.Domain.Entity;
using E_Commerce.CatalogService.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.CatalogService.Persistence.EntityConfiguration
{
    public class CatalogItemImageEntityConfiguration : IEntityTypeConfiguration<CatalogItemImage>
    {
        public void Configure(EntityTypeBuilder<CatalogItemImage> builder)
        {
            builder.ToTable("Catalog_Item_Image", CatalogContext.DEFAULT_SCHEMA);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.PictureFileName).IsRequired(false);
            builder.Ignore(x => x.PictureUrl);
            builder.HasOne(x => x.CatalogItem).WithMany(x => x.CatalogItemImages).HasForeignKey(x => x.CatalogItemId);


            CatalogItemImage[] catalogItemImages = new[] {
            new CatalogItemImage() {
            Id = 1,
            CatalogItemId = 1,
            CreatedDate= DateTime.Now,
            PictureFileName = "Airmax270.png"},
            new CatalogItemImage() {
            Id = 2,
            CatalogItemId = 2,
            CreatedDate= DateTime.Now,
            PictureFileName = "GoldenState2022/23_uniform.png" } ,
            new CatalogItemImage() {
            Id = 3,
            CatalogItemId = 3,
            CreatedDate= DateTime.Now,
            PictureFileName = "black_panther_Tshirt.png"}};

            builder.HasData(catalogItemImages);
        }

    }
}