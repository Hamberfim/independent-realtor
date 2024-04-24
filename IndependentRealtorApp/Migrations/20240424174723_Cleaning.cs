using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    public partial class Cleaning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    RealtorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealtorPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "publicUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publicUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PropertyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyAddress = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    PropertyCity = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    PropertyState = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    PropertyZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PropertyPrice = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealtorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_AspNetUsers_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyUsers",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyUsers", x => new { x.PropertyId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PropertyUsers_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyUsers_publicUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "publicUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RealtorEmail", "RealtorPassword", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "76cd1c1a-a753-4e6f-8d73-a8b587054a5b", 0, "bfa9d33e-4ed2-40e4-94bf-7045851a2eac", null, false, "Timothy", "Goodsale", false, null, null, null, null, null, false, "tgoodsale@fakerealty.com", "pass2", "1f962a18-6cf4-489f-8886-4832d1df846c", false, "Tim" });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "ImageUrl", "PropertyAddress", "PropertyCity", "PropertyDescription", "PropertyPrice", "PropertyState", "PropertyStatus", "PropertyTitle", "PropertyZip", "RealtorId" },
                values: new object[,]
                {
                    { 1, "images/1234olive.jpg", "1234 Olive St.", "Anytown", "3 bedroom, 2 bath cottage styled bungalow", 215000.0, "IA", "for sale", "Cottage Bungalow", "50266", null },
                    { 2, "images/5561artnuevo.jpg", "5561 Art Nuevo Ave.", "Sometown", "5 bedroom, 2.5 bath turn of the century deco styled two story", 450000.0, "IA", "for sale", "Deco Two Story", "50266", null },
                    { 3, "images/12gravel.jpg", "12 Gravel Rd.", "Ruraltown", "4 bedroom, 2 bath ranch acreage", 385000.0, "IA", "pending", "Ranch Acreage", "50266", null },
                    { 4, "images/321corinda.jpg", "321 Corinda St", "Anytown", "2 bedroom, 1.5 bath bungalow", 205000.0, "NY", "for sale", "Two bedroom Bungalow", "12345", null },
                    { 5, "images/756lincoln.jpg", "756 Lincoln Blvd.", "Metro-City", "3 bedroom, 2 bath Stylish Townhome", 279900.0, "IA", "for sale", "Stylish Townhome", "55555", null },
                    { 6, "images/5westwoods.jpg", "5 West Woods Rd", "Anytown", "17 undeveloped acres just west of the city.", 86700.0, "IA", "for sale", "17 acres for development", "55555", null },
                    { 7, "images/16east.jpg", "16 East Prosaic St", "Metro-City", "2 bedroom, 2 bath just minutes from downtown.", 199900.0, "IA", "for sale", "Charming home close to downtown", "55555", null }
                });

            migrationBuilder.InsertData(
                table: "publicUsers",
                columns: new[] { "UserId", "FirstName", "LastName", "UserEmail", "UserName", "UserPassword" },
                values: new object[,]
                {
                    { 1, "Sam", "Smith", "ssmith@fakeworld.net", "Sam", "pass1" },
                    { 2, "Linda", "Beltcher", "lbeltcher@fakeworld.net", "Linda", "pass1" },
                    { 3, "Bob", "Beltcher", "bbeltcher@fakeworld.net", "Bob", "pass1" },
                    { 4, "Kathy", "Klien", "kklien@fakeworld.net", "Kathy", "pass1" },
                    { 5, "Billy", "Williams", "bwilliams@fakeworld.net", "Billy", "pass1" },
                    { 6, "Sarah", "Seashell", "sseashell@fakeworld.net", "Sarah", "pass1" },
                    { 7, "Steven", "Klien", "sklien@fakeworld.net", "Steven", "pass1" }
                });

            migrationBuilder.InsertData(
                table: "PropertyUsers",
                columns: new[] { "PropertyId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 4 },
                    { 3, 7 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 3 },
                    { 5, 5 },
                    { 6, 2 },
                    { 6, 4 },
                    { 7, 1 },
                    { 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_RealtorId",
                table: "Properties",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyUsers_UserId",
                table: "PropertyUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PropertyUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "publicUsers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
