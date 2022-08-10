using Microsoft.EntityFrameworkCore.Migrations;

namespace Providers.Migrations
{
    public partial class SeedProviders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Location", "Name", "Price" },
                values: new object[] { 1, "Marco Bruto", "Lavabo 1", 200m });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Location", "Name", "Price" },
                values: new object[] { 2, "juan pablo laguna", "Lavabo 2", 250m });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Location", "Name", "Price" },
                values: new object[] { 3, "Test", "Lavabo 3", 300m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
