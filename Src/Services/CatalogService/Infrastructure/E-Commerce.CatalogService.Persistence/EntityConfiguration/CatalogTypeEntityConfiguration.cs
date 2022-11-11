using E_Commerce.CatalogService.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.CatalogService.Persistence.EntityConfiguration
{
    public class CatalogTypeEntityConfiguration : IEntityTypeConfiguration<CatalogType>
    {
        public void Configure(EntityTypeBuilder<CatalogType> builder)
        {
            builder.ToTable("Catalog_Type");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.Type).IsRequired().HasMaxLength(50);

            builder.HasMany(x => x.CatalogItems).WithOne(x => x.CatalogType).HasForeignKey(x => x.CatalogTypeId);


            CatalogType[] catalogTypes = new[] {
                new CatalogType() { Id= 1 , Type = "Shoes" ,CreatedDate = DateTime.Now } , new (){ Id=2 , Type= "T-Shirt" ,CreatedDate = DateTime.Now } , new (){  Id = 3 , Type = "tracksuit" , CreatedDate = DateTime.Now} };

            builder.HasData(catalogTypes);
        }
    }
}
