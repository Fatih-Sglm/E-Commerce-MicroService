using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.OrderService.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "ordering",
                table: "cardtypes",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Amex" },
                    { 2, "Visa" },
                    { 3, "MasterCard" },
                    { 4, "Capital One" }
                });

            migrationBuilder.InsertData(
                schema: "ordering",
                table: "orderstatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Submitted" },
                    { 2, "AwaitingValidation" },
                    { 3, "StockConfirmed" },
                    { 4, "Paid" },
                    { 5, "Shipped" },
                    { 6, "Cancelled" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "cardtypes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "cardtypes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "cardtypes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "cardtypes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "orderstatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "orderstatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "orderstatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "orderstatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "orderstatus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "ordering",
                table: "orderstatus",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
