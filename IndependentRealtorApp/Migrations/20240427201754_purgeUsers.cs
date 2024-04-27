using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class purgeUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4dedda3a-001b-4aeb-a0b7-ceae54c97ee0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 1, 0, "fcd21695-3756-4c29-af9d-ecd8b6ac159a", "tgoodsale@fakerealty.com", false, "Timothy", "Goodsale", false, null, null, null, null, null, false, null, false, "Tim", "pass2" },
                    { 2, 0, "596a738a-f093-45df-b4a2-e544c243f103", "lbeltcher@fakeworld.net", false, "Linda", "Beltcher", false, null, null, null, null, null, false, null, false, "Linda", "pass1" },
                    { 3, 0, "de262cde-0744-45dd-9827-adbb47405d15", "bbeltcher@fakeworld.net", false, "Bob", "Beltcher", false, null, null, null, null, null, false, null, false, "Bob", "pass1" },
                    { 4, 0, "6f5f4d9b-4488-43f9-a2c6-cc09f34cc2bb", "kklien@fakeworld.net", false, "Kathy", "Klien", false, null, null, null, null, null, false, null, false, "Kathy", "pass1" },
                    { 5, 0, "cf8ede18-c017-44bb-a06b-ec9c708b54a9", "bwilliams@fakeworld.net", false, "Billy", "Williams", false, null, null, null, null, null, false, null, false, "Billy", "pass1" },
                    { 6, 0, "201c38b7-bbfa-4a62-8ea3-a7a5f5482e8a", "sseashell@fakeworld.net", false, "Sarah", "Seashell", false, null, null, null, null, null, false, null, false, "Sarah", "pass1" },
                    { 7, 0, "80b7e1cb-0904-4ccc-b75e-1425a7934101", "sklien@fakeworld.net", false, "Steven", "Klien", false, null, null, null, null, null, false, null, false, "Steven", "pass1" }
                });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4eb8312f-609b-484a-97d0-98036dda3f4b");
        }
    }
}
