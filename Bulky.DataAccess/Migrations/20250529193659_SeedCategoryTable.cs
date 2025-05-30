using Microsoft.EntityFrameworkCore.Migrations;

namespace Bulky.DataAcess.Migrations
{
    public partial class SeedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categries",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 2, 2, "SciFi" });

            migrationBuilder.InsertData(
                table: "Categries",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 3, 3, "History" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
