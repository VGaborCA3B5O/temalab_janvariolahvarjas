using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class ModifySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Ugye nem csak én híztam be");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Ez bárcsak én lennék most");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Oké Pali bá");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "ProfilePicture", "UserName" },
                values: new object[] { "ef7a7950-45fd-49a7-86bc-9b3b94e7e382", "arnold@valami.hu", "Arnold", "defaultboy.jpg", "arnold" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "ProfilePicture", "UserName" },
                values: new object[] { "81664c7c-dfa6-457f-a1a8-226d9e04c760", "bence@valami.hu", "Bence", "defaultgirl.jpg", "bence" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "ProfilePicture", "UserName" },
                values: new object[] { "dfa357b6-18c0-4251-b63a-96c76d842e5a", "laura@valami.hu", "Laura", "defaultgirl.jpg", "laura" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Elso Post");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Masodik Post");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Harmadik Post");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "ProfilePicture", "UserName" },
                values: new object[] { "ea66574d-d24c-4e56-a955-a604d875bfe8", "Arnold@valami.hu", null, null, "Arnold" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "ProfilePicture", "UserName" },
                values: new object[] { "1191232f-cd99-4005-93c0-6cbd6b70cb5f", "Bence@valami.hu", null, null, "Bence" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "ProfilePicture", "UserName" },
                values: new object[] { "42789db5-f0cd-4f25-aeae-b75cec829cda", "Laura@valami.hu", null, null, "Laura" });
        }
    }
}
