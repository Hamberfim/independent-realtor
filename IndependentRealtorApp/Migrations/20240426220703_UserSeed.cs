using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0b005b89-be18-46e7-a27c-49391be2610b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 2, 0, "deccdf89-495a-49b8-ba29-10e8d72e9af5", "lbeltcher@fakeworld.net", false, "Linda", "Beltcher", false, null, null, null, null, null, false, null, false, "Linda", "pass1" },
                    { 3, 0, "f3d0deb3-497e-47f5-9b01-5248065ace8b", "bbeltcher@fakeworld.net", false, "Bob", "Beltcher", false, null, null, null, null, null, false, null, false, "Bob", "pass1" },
                    { 4, 0, "6bb2744f-0f2b-4bdb-ad83-b248de1542d1", "kklien@fakeworld.net", false, "Kathy", "Klien", false, null, null, null, null, null, false, null, false, "Kathy", "pass1" },
                    { 5, 0, "e6aec2f2-6b52-4a64-9bd9-35335e40c77c", "bwilliams@fakeworld.net", false, "Billy", "Williams", false, null, null, null, null, null, false, null, false, "Billy", "pass1" },
                    { 6, 0, "127f41cd-f4aa-4c22-b608-74b932c53a04", "sseashell@fakeworld.net", false, "Sarah", "Seashell", false, null, null, null, null, null, false, null, false, "Sarah", "pass1" },
                    { 7, 0, "b4ce4434-83c4-425d-9e27-6d231c14b8ac", "sklien@fakeworld.net", false, "Steven", "Klien", false, null, null, null, null, null, false, null, false, "Steven", "pass1" }
                });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8576a48c-baf9-4546-b8dc-4fc4831bd197");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "19ff4c95-16e3-47a6-b9b7-0336b2d2761c");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "439828df-f235-4538-9801-c63a0a96dc63");
        }
    }
}
