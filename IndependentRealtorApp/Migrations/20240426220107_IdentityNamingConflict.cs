using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityNamingConflict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "85e3bac8-2235-4119-bd0d-850bb06ee07d");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserEmail", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 1, 0, "2c8c79ac-d753-4345-93f7-85f4212fc9fa", null, false, "Sam", "Smith", false, null, null, null, null, null, false, null, false, "ssmith@fakeworld.net", "Sam", "pass1" },
                    { 2, 0, "24becca5-f91e-4407-8a57-51b737b6f950", null, false, "Linda", "Beltcher", false, null, null, null, null, null, false, null, false, "lbeltcher@fakeworld.net", "Linda", "pass1" },
                    { 3, 0, "18a33c5e-056a-4662-8146-ee889cfc8d7e", null, false, "Bob", "Beltcher", false, null, null, null, null, null, false, null, false, "bbeltcher@fakeworld.net", "Bob", "pass1" },
                    { 4, 0, "214582ff-429c-4821-bc60-e5db51d4b7b8", null, false, "Kathy", "Klien", false, null, null, null, null, null, false, null, false, "kklien@fakeworld.net", "Kathy", "pass1" },
                    { 5, 0, "795aafc7-f355-4eb3-8d35-8bab69ebabe7", null, false, "Billy", "Williams", false, null, null, null, null, null, false, null, false, "bwilliams@fakeworld.net", "Billy", "pass1" },
                    { 6, 0, "519c527e-cfae-40f6-a7e9-84835cba6691", null, false, "Sarah", "Seashell", false, null, null, null, null, null, false, null, false, "sseashell@fakeworld.net", "Sarah", "pass1" },
                    { 7, 0, "748e1860-f428-45f8-b6f3-401f85eebbf8", null, false, "Steven", "Klien", false, null, null, null, null, null, false, null, false, "sklien@fakeworld.net", "Steven", "pass1" }
                });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "aa2377b3-dce6-49b7-ab3e-4d99725b566a");

            migrationBuilder.InsertData(
                table: "PropertyUsers",
                columns: new[] { "PropertyId", "PublicUserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 7, 1 },
                    { 1, 2 },
                    { 6, 2 },
                    { 2, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 6, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 4, 6 },
                    { 3, 7 },
                    { 7, 7 }
                });
        }
    }
}
