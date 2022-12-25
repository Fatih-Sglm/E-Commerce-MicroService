using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.CatalogService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(8775), 1499.99m });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(8786), 1849.90m });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 365, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 365, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 365, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 365, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 365, DateTimeKind.Local).AddTicks(8604));
        }
    }
}
