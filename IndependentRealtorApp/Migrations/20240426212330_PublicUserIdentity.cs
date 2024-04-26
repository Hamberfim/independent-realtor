using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class PublicUserIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_AspNetUsers_RealtorId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyUsers_PublicUsers_PublicUserId",
                table: "PropertyUsers");

            migrationBuilder.DropTable(
                name: "PublicUsers");

            migrationBuilder.RenameColumn(
                name: "RealtorPassword",
                table: "AspNetUsers",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "RealtorEmail",
                table: "AspNetUsers",
                newName: "UserEmail");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125);

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    RealtorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealtorPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "UserEmail", "UserName", "UserPassword" },
                values: new object[] { "2c8c79ac-d753-4345-93f7-85f4212fc9fa", "Sam", "Smith", "ssmith@fakeworld.net", "Sam", "pass1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserEmail", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 2, 0, "24becca5-f91e-4407-8a57-51b737b6f950", null, false, "Linda", "Beltcher", false, null, null, null, null, null, false, null, false, "lbeltcher@fakeworld.net", "Linda", "pass1" },
                    { 3, 0, "18a33c5e-056a-4662-8146-ee889cfc8d7e", null, false, "Bob", "Beltcher", false, null, null, null, null, null, false, null, false, "bbeltcher@fakeworld.net", "Bob", "pass1" },
                    { 4, 0, "214582ff-429c-4821-bc60-e5db51d4b7b8", null, false, "Kathy", "Klien", false, null, null, null, null, null, false, null, false, "kklien@fakeworld.net", "Kathy", "pass1" },
                    { 5, 0, "795aafc7-f355-4eb3-8d35-8bab69ebabe7", null, false, "Billy", "Williams", false, null, null, null, null, null, false, null, false, "bwilliams@fakeworld.net", "Billy", "pass1" },
                    { 6, 0, "519c527e-cfae-40f6-a7e9-84835cba6691", null, false, "Sarah", "Seashell", false, null, null, null, null, null, false, null, false, "sseashell@fakeworld.net", "Sarah", "pass1" },
                    { 7, 0, "748e1860-f428-45f8-b6f3-401f85eebbf8", null, false, "Steven", "Klien", false, null, null, null, null, null, false, null, false, "sklien@fakeworld.net", "Steven", "pass1" }
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RealtorEmail", "RealtorPassword", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "aa2377b3-dce6-49b7-ab3e-4d99725b566a", null, false, "Timothy", "Goodsale", false, null, null, null, null, null, false, "tgoodsale@fakerealty.com", "pass2", null, false, "Tim" });

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties",
                column: "RealtorId",
                principalTable: "Realtors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyUsers_AspNetUsers_PublicUserId",
                table: "PropertyUsers",
                column: "PublicUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyUsers_AspNetUsers_PublicUserId",
                table: "PropertyUsers");

            migrationBuilder.DropTable(
                name: "Realtors");

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

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "AspNetUsers",
                newName: "RealtorPassword");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "AspNetUsers",
                newName: "RealtorEmail");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "PublicUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "RealtorEmail", "RealtorPassword", "UserName" },
                values: new object[] { "dc9c6e12-46fe-41da-971f-f31db1087f48", "Timothy", "Goodsale", "tgoodsale@fakerealty.com", "pass2", "Tim" });

            migrationBuilder.InsertData(
                table: "PublicUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserEmail", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 1, 0, "3ff3fe14-86d0-4791-8ba5-df46464623a4", null, false, "Sam", "Smith", false, null, null, null, null, null, false, null, false, "ssmith@fakeworld.net", "Sam", "pass1" },
                    { 2, 0, "10bc1d37-e5c8-4c59-bedf-87adad2a84a6", null, false, "Linda", "Beltcher", false, null, null, null, null, null, false, null, false, "lbeltcher@fakeworld.net", "Linda", "pass1" },
                    { 3, 0, "1b0af444-17d4-433a-b5ee-4812789a1078", null, false, "Bob", "Beltcher", false, null, null, null, null, null, false, null, false, "bbeltcher@fakeworld.net", "Bob", "pass1" },
                    { 4, 0, "90ce9475-5b9f-40b1-a493-69b7deee4cee", null, false, "Kathy", "Klien", false, null, null, null, null, null, false, null, false, "kklien@fakeworld.net", "Kathy", "pass1" },
                    { 5, 0, "3468731c-e3a7-46f2-9365-1fc3bb05fce4", null, false, "Billy", "Williams", false, null, null, null, null, null, false, null, false, "bwilliams@fakeworld.net", "Billy", "pass1" },
                    { 6, 0, "a2a8c37f-a4f1-4528-9e12-3f21ebb19c7d", null, false, "Sarah", "Seashell", false, null, null, null, null, null, false, null, false, "sseashell@fakeworld.net", "Sarah", "pass1" },
                    { 7, 0, "750ab18f-e53b-4dff-b479-81011ac2af23", null, false, "Steven", "Klien", false, null, null, null, null, null, false, null, false, "sklien@fakeworld.net", "Steven", "pass1" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_AspNetUsers_RealtorId",
                table: "Properties",
                column: "RealtorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyUsers_PublicUsers_PublicUserId",
                table: "PropertyUsers",
                column: "PublicUserId",
                principalTable: "PublicUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
