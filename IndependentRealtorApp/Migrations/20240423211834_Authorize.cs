using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class Authorize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyUsers_Users_UserId",
                table: "PropertyUsers");

            migrationBuilder.DropTable(
                name: "Realtors");

            migrationBuilder.DropIndex(
                name: "IX_Properties_RealtorId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "publicUsers");

            migrationBuilder.AddColumn<string>(
                name: "RealtorId1",
                table: "Properties",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RealtorEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RealtorId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RealtorPassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_publicUsers",
                table: "publicUsers",
                column: "UserId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RealtorEmail", "RealtorId", "RealtorPassword", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bfb022b3-4004-48ee-aa05-b34d18df1503", 0, "313d961e-8c6a-4ca7-b11f-4a5815c77dbe", null, false, "Timothy", "Goodsale", false, null, null, null, null, null, false, "tgoodsale@fakerealty.com", 1, "pass2", "49efcdb4-fdf2-428d-b2e6-fa6139b94cef", false, "Tim" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                column: "RealtorId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                column: "RealtorId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                column: "RealtorId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                column: "RealtorId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                column: "RealtorId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6,
                column: "RealtorId1",
                value: null);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                column: "RealtorId1",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_RealtorId1",
                table: "Properties",
                column: "RealtorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_AspNetUsers_RealtorId1",
                table: "Properties",
                column: "RealtorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyUsers_publicUsers_UserId",
                table: "PropertyUsers",
                column: "UserId",
                principalTable: "publicUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_AspNetUsers_RealtorId1",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyUsers_publicUsers_UserId",
                table: "PropertyUsers");

            migrationBuilder.DropIndex(
                name: "IX_Properties_RealtorId1",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publicUsers",
                table: "publicUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfb022b3-4004-48ee-aa05-b34d18df1503");

            migrationBuilder.DropColumn(
                name: "RealtorId1",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RealtorEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RealtorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RealtorPassword",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "publicUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    RealtorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealtorPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.RealtorId);
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "RealtorId", "FirstName", "LastName", "RealtorEmail", "RealtorPassword", "UserName" },
                values: new object[] { 1, "Timothy", "Goodsale", "tgoodsale@fakerealty.com", "pass2", "Tim" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_RealtorId",
                table: "Properties",
                column: "RealtorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Realtors_RealtorId",
                table: "Properties",
                column: "RealtorId",
                principalTable: "Realtors",
                principalColumn: "RealtorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyUsers_Users_UserId",
                table: "PropertyUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
