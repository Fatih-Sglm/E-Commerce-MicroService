using E_Commerce.CatalogService.Domain.Entity;
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
            builder.HasOne(x => x.CatalogItemFeature).WithOne().HasForeignKey<CatalogItemFeature>(ad => ad.CatalogItemId);

            CatalogItem[] catalogItems = new[] {
                new CatalogItem() { Id= 1 , CatalogTypeId=1 , CatalogBrandId = 1 ,  Name="Nike Air Max 270" ,
                    Description="Nike'ın günlük giyim için tasarlanmış ilk Air Max modeli olan Nike Air Max 270, " +
                    "dikkat çeken stili rahatlıkla buluşturuyor. Air Max ikonlarından ilham alan tasarım, " +
                    "büyük penceresi ve yeni renkleriyle Nike'ın en büyük yeniliğini sergiliyor." , Price =1499.99M ,CreatedDate = DateTime.Now } ,
                new CatalogItem() { Id= 2 , CatalogTypeId=2 , CatalogBrandId = 1 , Name="Golden State Warriors Icon Edition 2022/23" ,
                    Description="Her takımın onu ligdeki diğer takımlardan ayıran gerçek renkleri ve eşsiz bir kimliği bulunur. Zengin basketbol mirasını onurlandıran bu Golden State Warriors Forma, takım ayrıntılarından ter tutmayan hafif fileye kadar profesyonellerin sahada giydiği formalardan ilham alır. " +
                    "Favori oyuncunu ve sevdiğin oyunu temsil ederken hem sahada hem de saha dışında kuru ve serin kalmana yardımcı olur" , Price =1849.90M ,CreatedDate = DateTime.Now} ,
                new CatalogItem() { Id= 3 , CatalogTypeId=2 , CatalogBrandId = 1 , Name="BLACK PANTHER GRAPHİC TİŞÖRT" ,
                    Description="Önden mütevazi. Arkadan nefes kesici. Bu adidas tişört, " +
                    "bir süper kahraman gibi sürprizlerle dolu. Marvel'in Kara Panter karakterinden " +
                    "ilham alan bu tişört, kalın pamuklu kumaştan üretilmiştir. " +
                    "Gardırobundaki her parça ile mükemmel biçimde eşleşen model, " +
                    "serin havalarda hem sıcak kalmanı hem şık görünmeni sağlar." +
                    "\r\n\r\nPamuklu ürünlerimiz, sürdürülebilir pamuk çiftçiliğini destekler." , Price =1499.99M , CreatedDate = DateTime.Now} };

            builder.HasData(catalogItems);
        }
    }
}
