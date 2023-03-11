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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Item_Feature",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariantDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Item_Feature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Type",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "Catalog_Item_Image",
                schema: "catalog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHeader = table.Column<bool>(type: "bit", nullable: false),
                    CatalogItemId = table.Column<long>(type: "bigint", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "CatalogItemCatalogItemVariant",
                schema: "catalog",
                columns: table => new
                {
                    CatalogItemVariantsId = table.Column<long>(type: "bigint", nullable: false),
                    CatalogItemsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemCatalogItemVariant", x => new { x.CatalogItemVariantsId, x.CatalogItemsId });
                    table.ForeignKey(
                        name: "FK_CatalogItemCatalogItemVariant_Catalog_Item_CatalogItemsId",
                        column: x => x.CatalogItemsId,
                        principalSchema: "catalog",
                        principalTable: "Catalog_Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogItemCatalogItemVariant_Catalog_Item_Feature_CatalogItemVariantsId",
                        column: x => x.CatalogItemVariantsId,
                        principalSchema: "catalog",
                        principalTable: "Catalog_Item_Feature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Brand",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 11, 18, 23, 45, 55, 198, DateTimeKind.Local).AddTicks(7855), "Nike", null },
                    { 2L, new DateTime(2022, 11, 18, 23, 45, 55, 198, DateTimeKind.Local).AddTicks(7874), "Adidas", null },
                    { 3L, new DateTime(2022, 11, 18, 23, 45, 55, 198, DateTimeKind.Local).AddTicks(7876), "Puma", null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Type",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 11, 18, 23, 45, 55, 202, DateTimeKind.Local).AddTicks(2373), "Shoes", null },
                    { 2L, new DateTime(2022, 11, 18, 23, 45, 55, 202, DateTimeKind.Local).AddTicks(2387), "T-Shirt", null },
                    { 3L, new DateTime(2022, 11, 18, 23, 45, 55, 202, DateTimeKind.Local).AddTicks(2390), "tracksuit", null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item",
                columns: new[] { "Id", "CatalogBrandId", "CatalogTypeId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(173), "Nike'ın günlük giyim için tasarlanmış ilk Air Max modeli olan Nike Air Max 270, dikkat çeken stili rahatlıkla buluşturuyor. Air Max ikonlarından ilham alan tasarım, büyük penceresi ve yeni renkleriyle Nike'ın en büyük yeniliğini sergiliyor.", "Nike Air Max 270", 1499.99m, null },
                    { 2L, 1L, 2L, new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(190), "Her takımın onu ligdeki diğer takımlardan ayıran gerçek renkleri ve eşsiz bir kimliği bulunur. Zengin basketbol mirasını onurlandıran bu Golden State Warriors Forma, takım ayrıntılarından ter tutmayan hafif fileye kadar profesyonellerin sahada giydiği formalardan ilham alır. Favori oyuncunu ve sevdiğin oyunu temsil ederken hem sahada hem de saha dışında kuru ve serin kalmana yardımcı olur", "Golden State Warriors Icon Edition 2022/23", 1849.90m, null }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                columns: new[] { "Id", "CatalogItemId", "CreatedDate", "FileName", "IsHeader", "Path", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(9655), "Airmax270.png", false, "Product//Shoes//Airmax270.png", null },
                    { 2L, 2L, new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(9673), "GoldenState2022/23_uniform.png", false, "Product//T-Shirt//GoldenState2022/23_uniform.png", null }
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
                name: "IX_Catalog_Item_Image_CatalogItemId",
                schema: "catalog",
                table: "Catalog_Item_Image",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemCatalogItemVariant_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant",
                column: "CatalogItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_Item_Image",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "CatalogItemCatalogItemVariant",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Catalog_Item",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "Catalog_Item_Feature",
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
