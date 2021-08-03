using Microsoft.EntityFrameworkCore.Migrations;

namespace CookieShop.Server.Migrations
{
    public partial class ProductVariantsFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 7 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 49.99m, 39.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 9, 7 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 39.99m, 29.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 59.99m, 49.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 9, 8 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 49.99m, 39.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 9 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 34.99m, 24.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 16.99m, 14.99m });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 0m, 3.99m },
                    { 1, 4, 0m, 3.99m },
                    { 1, 5, 0m, 3.99m },
                    { 1, 3, 0m, 5.99m },
                    { 1, 2, 0m, 4.99m },
                    { 1, 6, 0m, 5.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 7 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 39.99m, 29.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 9, 7 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 49.99m, 39.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 49.99m, 39.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 9, 8 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 59.99m, 49.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 8, 9 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 16.99m, 14.99m });

            migrationBuilder.UpdateData(
                table: "ProductVariant",
                keyColumns: new[] { "EditionId", "ProductId" },
                keyValues: new object[] { 9, 9 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 34.99m, 24.99m });
        }
    }
}
