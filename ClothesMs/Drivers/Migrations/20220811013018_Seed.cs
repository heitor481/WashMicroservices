using Microsoft.EntityFrameworkCore.Migrations;

namespace Drivers.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 1, "Hunter", "Ribeiro" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 2, "Dante", "Ribeiro" });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 3, "Test", "Ribeiro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
