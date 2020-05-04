using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingApi.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShoppingItems",
                columns: new[] { "Id", "Description", "Purchased", "PurchasedFrom" },
                values: new object[] { 1, "Beer", false, null });

            migrationBuilder.InsertData(
                table: "ShoppingItems",
                columns: new[] { "Id", "Description", "Purchased", "PurchasedFrom" },
                values: new object[] { 2, "Toilet Paper", true, "Acme" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShoppingItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingItems",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
