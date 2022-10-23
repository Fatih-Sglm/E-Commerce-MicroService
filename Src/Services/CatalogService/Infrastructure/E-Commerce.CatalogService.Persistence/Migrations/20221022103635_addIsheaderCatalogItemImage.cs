using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.CatalogService.Persistence.Migrations
{
    public partial class addIsheaderCatalogItemImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHeader",
                schema: "catalog",
                table: "Catalog_Item_Image",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 495, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 495, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 495, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 496, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 496, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 496, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 497, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 497, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 497, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 497, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 497, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 497, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 496, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 496, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 22, 13, 36, 35, 496, DateTimeKind.Local).AddTicks(5692));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHeader",
                schema: "catalog",
                table: "Catalog_Item_Image");

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 15, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 15, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 15, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Feature",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 17, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 10, 20, 21, 40, 31, 16, DateTimeKind.Local).AddTicks(8701));
        }
    }
}
