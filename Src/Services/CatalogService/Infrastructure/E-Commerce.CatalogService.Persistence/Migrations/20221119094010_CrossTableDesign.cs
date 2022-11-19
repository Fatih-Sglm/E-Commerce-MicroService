using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.CatalogService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CrossTableDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItemCatalogItemVariant_Catalog_Item_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItemCatalogItemVariant_Catalog_Item_Feature_CatalogItemVariantsId",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogItemCatalogItemVariant",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catalog_Item_Feature",
                schema: "catalog",
                table: "Catalog_Item_Feature");

            migrationBuilder.RenameTable(
                name: "CatalogItemCatalogItemVariant",
                schema: "catalog",
                newName: "CatalogItemsVariants",
                newSchema: "catalog");

            migrationBuilder.RenameTable(
                name: "Catalog_Item_Feature",
                schema: "catalog",
                newName: "CatalogItemVariant",
                newSchema: "catalog");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItemCatalogItemVariant_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemsVariants",
                newName: "IX_CatalogItemsVariants_CatalogItemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogItemsVariants",
                schema: "catalog",
                table: "CatalogItemsVariants",
                columns: new[] { "CatalogItemVariantsId", "CatalogItemsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogItemVariant",
                schema: "catalog",
                table: "CatalogItemVariant",
                column: "Id");

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
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 12, 40, 10, 364, DateTimeKind.Local).AddTicks(8786));

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

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItemsVariants_CatalogItemVariant_CatalogItemVariantsId",
                schema: "catalog",
                table: "CatalogItemsVariants",
                column: "CatalogItemVariantsId",
                principalSchema: "catalog",
                principalTable: "CatalogItemVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItemsVariants_Catalog_Item_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemsVariants",
                column: "CatalogItemsId",
                principalSchema: "catalog",
                principalTable: "Catalog_Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItemsVariants_CatalogItemVariant_CatalogItemVariantsId",
                schema: "catalog",
                table: "CatalogItemsVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogItemsVariants_Catalog_Item_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemsVariants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogItemVariant",
                schema: "catalog",
                table: "CatalogItemVariant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogItemsVariants",
                schema: "catalog",
                table: "CatalogItemsVariants");

            migrationBuilder.RenameTable(
                name: "CatalogItemVariant",
                schema: "catalog",
                newName: "Catalog_Item_Feature",
                newSchema: "catalog");

            migrationBuilder.RenameTable(
                name: "CatalogItemsVariants",
                schema: "catalog",
                newName: "CatalogItemCatalogItemVariant",
                newSchema: "catalog");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItemsVariants_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant",
                newName: "IX_CatalogItemCatalogItemVariant_CatalogItemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catalog_Item_Feature",
                schema: "catalog",
                table: "Catalog_Item_Feature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogItemCatalogItemVariant",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant",
                columns: new[] { "CatalogItemVariantsId", "CatalogItemsId" });

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 198, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 198, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Brand",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 198, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Item_Image",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 200, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 202, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 202, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                schema: "catalog",
                table: "Catalog_Type",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 18, 23, 45, 55, 202, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItemCatalogItemVariant_Catalog_Item_CatalogItemsId",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant",
                column: "CatalogItemsId",
                principalSchema: "catalog",
                principalTable: "Catalog_Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogItemCatalogItemVariant_Catalog_Item_Feature_CatalogItemVariantsId",
                schema: "catalog",
                table: "CatalogItemCatalogItemVariant",
                column: "CatalogItemVariantsId",
                principalSchema: "catalog",
                principalTable: "Catalog_Item_Feature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
