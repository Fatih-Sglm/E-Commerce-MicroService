using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.CatalogService.Persistence.EntityConfiguration
{
    public class CatalogItemImageEntityConfiguration : IEntityTypeConfiguration<CatalogItemImage>
    {
        public void Configure(EntityTypeBuilder<CatalogItemImage> builder)
        {
            builder.ToTable("Catalog_Item_Image");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.PictureFileName).IsRequired(false);
            builder.Property(x => x.FolderName).IsRequired(false);
            builder.HasOne(x => x.CatalogItem).WithMany(x => x.CatalogItemImages).HasForeignKey(x => x.CatalogItemId);


            CatalogItemImage[] catalogItemImages = new[] {
            new CatalogItemImage() {
            Id = 1,
            CatalogItemId = 1,
            CreatedDate= DateTime.Now,
            FolderName = "Product//Shoes",
            PictureFileName = "Airmax270.png"},
            new CatalogItemImage() {
            Id = 2,
            CatalogItemId = 2,
            CreatedDate= DateTime.Now,
            FolderName = "Product//T-Shirt",
            PictureFileName = "GoldenState2022/23_uniform.png" } ,
            new CatalogItemImage() {
            Id = 3,
            CatalogItemId = 3,
            CreatedDate= DateTime.Now,
            FolderName = "Product//T-Shirt",
            PictureFileName = "black_panther_Tshirt.png"}};

            builder.HasData(catalogItemImages);
        }

    }
}
