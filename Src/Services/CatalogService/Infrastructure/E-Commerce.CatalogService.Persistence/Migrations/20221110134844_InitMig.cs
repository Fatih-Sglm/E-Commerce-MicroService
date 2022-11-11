using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.CatalogService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "catalog");
            migrationBuilder.CreateTable(
                name: "Catalog_Brand",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CatalogBrandId = table.Column<long>(type: "bigint", nullable: false),
                    CatalogTypeId = table.Column<long>(type: "bigint", nullable: false),
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genders = table.Column<int>(type: "int", nullable: false),
                    BodySize = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableStock = table.Column<long>(type: "bigint", nullable: false),
                    CatalogItemId = table.Column<long>(type: "bigint", nullable: false),
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogItemId = table.Column<long>(type: "bigint", nullable: false),
                    IsHeader = table.Column<bool>(type: "bit", nullable: false),
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
                    { 1L, "Nike", new DateTime(2022, 11, 10, 16, 48, 44, 627, DateTimeKind.Local).AddTicks(7574), null },
                    { 2L, "Adidas", new DateTime(2022, 11, 10, 16, 48, 44, 627, DateTimeKind.Local).AddTicks(7591), null },
                    { 3L, "Puma", new DateTime(2022, 11, 10, 16, 48, 44, 627, DateTimeKind.Local).AddTicks(7592), null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Type",
                columns: new[] { "Id", "CreatedDate", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 11, 10, 16, 48, 44, 632, DateTimeKind.Local).AddTicks(8497), "Shoes", null },
                    { 2L, new DateTime(2022, 11, 10, 16, 48, 44, 632, DateTimeKind.Local).AddTicks(8504), "T-Shirt", null },
                    { 3L, new DateTime(2022, 11, 10, 16, 48, 44, 632, DateTimeKind.Local).AddTicks(8505), "tracksuit", null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item",
                columns: new[] { "Id", "CatalogBrandId", "CatalogTypeId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, new DateTime(2022, 11, 10, 16, 48, 44, 630, DateTimeKind.Local).AddTicks(6445), "Nike'ın günlük giyim için tasarlanmış ilk Air Max modeli olan Nike Air Max 270, dikkat çeken stili rahatlıkla buluşturuyor. Air Max ikonlarından ilham alan tasarım, büyük penceresi ve yeni renkleriyle Nike'ın en büyük yeniliğini sergiliyor.", "Nike Air Max 270", 1499.99m, null },
                    { 2L, 1L, 2L, new DateTime(2022, 11, 10, 16, 48, 44, 630, DateTimeKind.Local).AddTicks(6458), "Her takımın onu ligdeki diğer takımlardan ayıran gerçek renkleri ve eşsiz bir kimliği bulunur. Zengin basketbol mirasını onurlandıran bu Golden State Warriors Forma, takım ayrıntılarından ter tutmayan hafif fileye kadar profesyonellerin sahada giydiği formalardan ilham alır. Favori oyuncunu ve sevdiğin oyunu temsil ederken hem sahada hem de saha dışında kuru ve serin kalmana yardımcı olur", "Golden State Warriors Icon Edition 2022/23", 1849.90m, null },
                    { 3L, 1L, 2L, new DateTime(2022, 11, 10, 16, 48, 44, 630, DateTimeKind.Local).AddTicks(6460), "Önden mütevazi. Arkadan nefes kesici. Bu adidas tişört, bir süper kahraman gibi sürprizlerle dolu. Marvel'in Kara Panter karakterinden ilham alan bu tişört, kalın pamuklu kumaştan üretilmiştir. Gardırobundaki her parça ile mükemmel biçimde eşleşen model, serin havalarda hem sıcak kalmanı hem şık görünmeni sağlar.\r\n\r\nPamuklu ürünlerimiz, sürdürülebilir pamuk çiftçiliğini destekler.", "BLACK PANTHER GRAPHİC TİŞÖRT", 1499.99m, null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                columns: new[] { "Id", "AvailableStock", "BodySize", "CatalogItemId", "CreatedDate", "Genders", "Size", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 100L, null, 1L, new DateTime(2022, 11, 10, 16, 48, 44, 631, DateTimeKind.Local).AddTicks(6878), 2, "43", null },
                    { 2L, 100L, 1, 2L, new DateTime(2022, 11, 10, 16, 48, 44, 631, DateTimeKind.Local).AddTicks(6887), 0, null, null },
                    { 3L, 50L, 2, 3L, new DateTime(2022, 11, 10, 16, 48, 44, 631, DateTimeKind.Local).AddTicks(6890), 2, null, null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                columns: new[] { "Id", "CatalogItemId", "CreatedDate", "IsHeader", "PictureFileName", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 11, 10, 16, 48, 44, 632, DateTimeKind.Local).AddTicks(2413), false, "Airmax270.png", null },
                    { 2L, 2L, new DateTime(2022, 11, 10, 16, 48, 44, 632, DateTimeKind.Local).AddTicks(2422), false, "GoldenState2022/23_uniform.png", null },
                    { 3L, 3L, new DateTime(2022, 11, 10, 16, 48, 44, 632, DateTimeKind.Local).AddTicks(2423), false, "black_panther_Tshirt.png", null }
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

        /// <inheritdoc />
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
