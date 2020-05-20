using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class AddProfilePictureToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profil",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Introduction", "PasswordHash" },
                values: new object[] { "ea66574d-d24c-4e56-a955-a604d875bfe8", "Sziasztok!", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Introduction", "PasswordHash" },
                values: new object[] { "1191232f-cd99-4005-93c0-6cbd6b70cb5f", "Sziasztok!", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Introduction", "PasswordHash" },
                values: new object[] { "42789db5-f0cd-4f25-aeae-b75cec829cda", "Sziasztok!", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Profil",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Profil" },
                values: new object[] { "260037fa-6ba6-4926-bfdf-cd03ca8ad17c", "Agaxy0408!", "Sziasztok!" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Profil" },
                values: new object[] { "3522da52-a3e7-44b5-bbd3-7e16d7d19d5d", "Agaxy0408!", "Sziasztok!" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Profil" },
                values: new object[] { "ca99060b-41d2-45fe-b4df-2aa940b67134", "Agaxy0408!", "Sziasztok!" });
        }
    }
}
