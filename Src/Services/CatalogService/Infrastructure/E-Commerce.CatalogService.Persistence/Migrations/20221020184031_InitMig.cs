using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.CatalogService.Persistence.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "catalog");

            migrationBuilder.CreateTable(
                name: "Catalog_Brand",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Type",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Item",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CatalogBrandId = table.Column<int>(type: "int", nullable: false),
                    CatalogTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catalog_Item_Catalog_Brand_CatalogBrandId",
                        column: x => x.CatalogBrandId,
                        principalSchema: "catalog",
                        principalTable: "Catalog_Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Catalog_Item_Catalog_Type_CatalogTypeId",
                        column: x => x.CatalogTypeId,
                        principalSchema: "catalog",
                        principalTable: "Catalog_Type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Item_Feature",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genders = table.Column<int>(type: "int", nullable: false),
                    BodySize = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableStock = table.Column<int>(type: "int", nullable: false),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Item_Feature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catalog_Item_Feature_Catalog_Item_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalSchema: "catalog",
                        principalTable: "Catalog_Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Item_Image",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Item_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catalog_Item_Image_Catalog_Item_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalSchema: "catalog",
                        principalTable: "Catalog_Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Brand",
                columns: new[] { "Id", "Brand", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Nike", new DateTime(2022, 10, 20, 21, 40, 31, 15, DateTimeKind.Local).AddTicks(1923), null },
                    { 2, "Adidas", new DateTime(2022, 10, 20, 21, 40, 31, 15, DateTimeKind.Local).AddTicks(1936), null },
                    { 3, "Puma", new DateTime(2022, 10, 20, 21, 40, 31, 15, DateTimeKind.Local).AddTicks(1937), null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Type",
                columns: new[] { "Id", "CreatedDate", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(8696), "Shoes", null },
                    { 2, new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(8700), "T-Shirt", null },
                    { 3, new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(8701), "tracksuit", null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item",
                columns: new[] { "Id", "CatalogBrandId", "CatalogTypeId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(7374), "Nike'ın günlük giyim için tasarlanmış ilk Air Max modeli olan Nike Air Max 270, dikkat çeken stili rahatlıkla buluşturuyor. Air Max ikonlarından ilham alan tasarım, büyük penceresi ve yeni renkleriyle Nike'ın en büyük yeniliğini sergiliyor.", "Nike Air Max 270", 1499.99m, null });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item",
                columns: new[] { "Id", "CatalogBrandId", "CatalogTypeId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[] { 2, 1, 2, new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(7385), "Her takımın onu ligdeki diğer takımlardan ayıran gerçek renkleri ve eşsiz bir kimliği bulunur. Zengin basketbol mirasını onurlandıran bu Golden State Warriors Forma, takım ayrıntılarından ter tutmayan hafif fileye kadar profesyonellerin sahada giydiği formalardan ilham alır. Favori oyuncunu ve sevdiğin oyunu temsil ederken hem sahada hem de saha dışında kuru ve serin kalmana yardımcı olur", "Golden State Warriors Icon Edition 2022/23", 1849.90m, null });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item",
                columns: new[] { "Id", "CatalogBrandId", "CatalogTypeId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[] { 3, 1, 2, new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(7386), "Önden mütevazi. Arkadan nefes kesici. Bu adidas tişört, bir süper kahraman gibi sürprizlerle dolu. Marvel'in Kara Panter karakterinden ilham alan bu tişört, kalın pamuklu kumaştan üretilmiştir. Gardırobundaki her parça ile mükemmel biçimde eşleşen model, serin havalarda hem sıcak kalmanı hem şık görünmeni sağlar.\r\n\r\nPamuklu ürünlerimiz, sürdürülebilir pamuk çiftçiliğini destekler.", "BLACK PANTHER GRAPHİC TİŞÖRT", 1499.99m, null });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                columns: new[] { "Id", "AvailableStock", "BodySize", "CatalogItemId", "CreatedDate", "Genders", "Size", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 100, null, 1, new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(6186), 2, "43", null },
                    { 2, 100, 1, 2, new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(6193), 0, null, null },
                    { 3, 50, 2, 3, new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(6195), 2, null, null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                columns: new[] { "Id", "CatalogItemId", "CreatedDate", "PictureFileName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(9850), "Airmax270.png", null },
                    { 2, 2, new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(9856), "GoldenState2022/23_uniform.png", null },
                    { 3, 3, new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(9857), "black_panther_Tshirt.png", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Item_CatalogBrandId",
                schema: "catalog",
                table: "Catalog_Item",
                column: "CatalogBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Item_CatalogTypeId",
                schema: "catalog",
                table: "Catalog_Item",
                column: "CatalogTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Item_Feature_CatalogItemId",
                schema: "catalog",
                table: "Catalog_Item_Feature",
                column: "CatalogItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Item_Image_CatalogItemId",
                schema: "catalog",
                table: "Catalog_Item_Image",
                column: "CatalogItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_Item_Feature",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Catalog_Item_Image",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Catalog_Item",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Catalog_Brand",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Catalog_Type",
                schema: "catalog");
        }
    }
}
