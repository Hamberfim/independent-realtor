using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class FreshApplicationRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "PublicUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "PublicUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "PublicUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "PublicUsers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "PublicUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "PublicUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dc9c6e12-46fe-41da-971f-f31db1087f48");

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "3ff3fe14-86d0-4791-8ba5-df46464623a4", null, false, false, null, null, null, null, null, false, null, false });

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "10bc1d37-e5c8-4c59-bedf-87adad2a84a6", null, false, false, null, null, null, null, null, false, null, false });

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "1b0af444-17d4-433a-b5ee-4812789a1078", null, false, false, null, null, null, null, null, false, null, false });

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "90ce9475-5b9f-40b1-a493-69b7deee4cee", null, false, false, null, null, null, null, null, false, null, false });

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "3468731c-e3a7-46f2-9365-1fc3bb05fce4", null, false, false, null, null, null, null, null, false, null, false });

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "a2a8c37f-a4f1-4528-9e12-3f21ebb19c7d", null, false, false, null, null, null, null, null, false, null, false });

            migrationBuilder.UpdateData(
                table: "PublicUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { 0, "750ab18f-e53b-4dff-b479-81011ac2af23", null, false, false, null, null, null, null, null, false, null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "PublicUsers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "PublicUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "PublicUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bdd3386a-9af6-4248-9631-e02ce957c777");
        }
    }
}
