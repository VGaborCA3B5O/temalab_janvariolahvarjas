using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class SeedDataChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "ProfilePicture" },
                values: new object[] { "10a49fba-244a-4f4e-8f18-e61b4ddda629", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "ProfilePicture" },
                values: new object[] { "6e8557b0-d980-4909-9ebb-2c8c26c99bc1", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "ProfilePicture" },
                values: new object[] { "3362d046-ba64-4f01-b3fa-d4f69239cfb4", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "ProfilePicture" },
                values: new object[] { "ef7a7950-45fd-49a7-86bc-9b3b94e7e382", "defaultboy.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "ProfilePicture" },
                values: new object[] { "81664c7c-dfa6-457f-a1a8-226d9e04c760", "defaultgirl.jpg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "ProfilePicture" },
                values: new object[] { "dfa357b6-18c0-4251-b63a-96c76d842e5a", "defaultgirl.jpg" });
        }
    }
}
