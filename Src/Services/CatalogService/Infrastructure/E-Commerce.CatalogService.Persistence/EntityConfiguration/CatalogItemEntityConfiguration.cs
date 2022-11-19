using E_Commerce.CatalogService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.CatalogService.Persistence.EntityConfiguration
{
    public class CatalogItemEntityConfiguration : IEntityTypeConfiguration<CatalogItem>
    {


        public void Configure(EntityTypeBuilder<CatalogItem> builder)
        {
            builder.ToTable("Catalog_Item");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Price).IsRequired();
            builder.HasOne(x => x.CatalogBrand).WithMany(x => x.CatalogItems).HasForeignKey(x => x.CatalogBrandId);
            builder.HasOne(x => x.CatalogType).WithMany(x => x.CatalogItems).HasForeignKey(x => x.CatalogTypeId);
            builder.HasMany(x => x.CatalogItemImages).WithOne(x => x.CatalogItem).HasForeignKey(x => x.CatalogItemId);
            builder.HasMany(x => x.CatalogItemVariants).WithMany(x => x.CatalogItems).
                UsingEntity(join => join.ToTable("CatalogItemsVariants"));

            CatalogItem catalogItem = new()
            {
                Id = 1,
                CatalogTypeId = 1,
                CatalogBrandId = 1,
                Name = "Nike Air Max 270",
                Description = "Nike'ın günlük giyim için tasarlanmış ilk Air Max modeli olan Nike Air Max 270, " +
                    "dikkat çeken stili rahatlıkla buluşturuyor. Air Max ikonlarından ilham alan tasarım, " +
                    "büyük penceresi ve yeni renkleriyle Nike'ın en büyük yeniliğini sergiliyor.",
                Price = 1499.99M,
                CreatedDate = DateTime.Now,

            };

            CatalogItem catalogItem1 = new()
            {
                Id = 2,
                CatalogTypeId = 2,
                CatalogBrandId = 1,
                Name = "Golden State Warriors Icon Edition 2022/23",
                Description = "Her takımın onu ligdeki diğer takımlardan ayıran gerçek renkleri ve eşsiz bir kimliği bulunur. Zengin basketbol mirasını onurlandıran bu Golden State Warriors Forma, takım ayrıntılarından ter tutmayan hafif fileye kadar profesyonellerin sahada giydiği formalardan ilham alır. " +
               "Favori oyuncunu ve sevdiğin oyunu temsil ederken hem sahada hem de saha dışında kuru ve serin kalmana yardımcı olur",
                Price = 1849.90M,
                CreatedDate = DateTime.Now
            };

            builder.HasData(catalogItem, catalogItem1);

        }
    }
}
