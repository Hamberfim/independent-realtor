using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class RealtIdError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "RealtorId",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                column: "RealtorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "b7b32c1a-5eeb-4b0b-90c8-0c81dcdc2a68");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties",
                column: "RealtorId",
                principalTable: "Realtors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "RealtorId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7,
                column: "RealtorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4dedda3a-001b-4aeb-a0b7-ceae54c97ee0");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties",
                column: "RealtorId",
                principalTable: "Realtors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
