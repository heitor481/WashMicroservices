using Microsoft.EntityFrameworkCore.Migrations;

namespace WashClothes.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "FullName", "UserName" },
                values: new object[] { 1, 30, "Test", "Test" });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Color", "Type", "UserId" },
                values: new object[] { 1, "Red", 4, 1 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Color", "Type", "UserId" },
                values: new object[] { 2, "Blue", 1, 1 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Color", "Type", "UserId" },
                values: new object[] { 3, "Green", 0, 1 });
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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
