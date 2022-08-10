using Microsoft.EntityFrameworkCore.Migrations;

namespace WashClothes.Migrations
{
    public partial class AddedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Color", "Type" },
                values: new object[] { 1, "Red", 4 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Color", "Type" },
                values: new object[] { 2, "Blue", 1 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Color", "Type" },
                values: new object[] { 3, "Green", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
