using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.CatalogService.Persistence.EntityConfiguration
{
    public class CatalogBrandEntityConfiguration : IEntityTypeConfiguration<CatalogBrand>
    {
        public void Configure(EntityTypeBuilder<CatalogBrand> builder)
        {
            builder.ToTable("Catalog_Brand");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);

            builder.Property(x => x.Brand).IsRequired().HasMaxLength(50);
            builder.HasMany(x => x.CatalogItems).WithOne(x => x.CatalogBrand).HasForeignKey(x => x.CatalogBrandId);



            CatalogBrand[] catalogBrands = new[] {
                new CatalogBrand() { Id= 1 , Brand = "Nike", CreatedDate = DateTime.Now } , new (){ Id=2 , Brand= "Adidas" , CreatedDate = DateTime.Now} , new (){  Id = 3 , Brand = "Puma", CreatedDate = DateTime.Now} };

            builder.HasData(catalogBrands);
        }
    }
}
