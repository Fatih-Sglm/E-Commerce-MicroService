using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.CatalogService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateCatalogItemPriceDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "catalog",
                table: "Catalog_Item",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 475, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 475, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 475, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(3026), 1499.99m });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(3034), 1849.90m });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 476, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 477, DateTimeKind.Local).AddTicks(4987));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 477, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 3, 12, 42, 477, DateTimeKind.Local).AddTicks(5002));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                schema: "catalog",
                table: "Catalog_Item",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 5, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 5, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 5, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 22, 55, 34, 5, DateTimeKind.Local).AddTicks(9459), 1499.99 });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 12, 7, 22, 55, 34, 5, DateTimeKind.Local).AddTicks(9469), 1849.9000000000001 });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 6, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 6, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 7, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 7, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 7, 22, 55, 34, 7, DateTimeKind.Local).AddTicks(627));
        }
    }
}
