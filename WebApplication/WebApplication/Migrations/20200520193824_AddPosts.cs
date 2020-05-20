using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class AddPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Ideje megtanulni kezetmosni");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Fujj");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Norbi");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "Milyen igaz :(");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Korona megoldja úgyis");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Szep");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Szilárd papa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "79b23eae-5627-409b-8bb8-2aa22f665ade");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fd7e6469-4d22-47b8-b1f9-9fd08dcb2821");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1c25c73f-854b-4e09-8a33-87720c0386a2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Post4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Post5");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Post6");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "Post7");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Post8");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "Post9");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "Post10");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ImageName", "Title", "UserId" },
                values: new object[] { 11, "11.jpg", "Post11", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5873953c-68cb-4931-b031-b158e0ffb45c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "912f4b1b-cd6d-4cd6-a90d-890783e030a5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "10727c08-0382-4764-9f71-252474a58385");
        }
    }
}
