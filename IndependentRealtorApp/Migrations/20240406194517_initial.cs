using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    RealtorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.RealtorId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
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
                    PropertyZip = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PropertyStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PropertyPrice = table.Column<double>(type: "float", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_Realtors_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "Realtors",
                        principalColumn: "RealtorId",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_PropertyUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "RealtorId", "FirstName", "LastName", "RealtorEmail" },
                values: new object[] { 1, "Timothy", "Goodsale", "tgoodsale@fakerealty.com" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "UserEmail" },
                values: new object[,]
                {
                    { 1, "Sam", "Smith", "ssmith@fakeworld.net" },
                    { 2, "Linda", "Beltcher", "lbeltcher@fakeworld.net" },
                    { 3, "Bob", "Beltcher", "bbeltcher@fakeworld.net" },
                    { 4, "Kathy", "Klien", "kklien@fakeworld.net" },
                    { 5, "Billy", "Williams", "bwilliams@fakeworld.net" },
                    { 6, "Sarah", "Seashell", "sseashell@fakeworld.net" },
                    { 7, "Steven", "Klien", "sklien@fakeworld.net" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "PropertyAddress", "PropertyCity", "PropertyDescription", "PropertyPrice", "PropertyState", "PropertyStatus", "PropertyTitle", "PropertyZip", "RealtorId", "imageUrl" },
                values: new object[,]
                {
                    { 1, "1234 Olive St.", "Anytown", "3 bedroom, 2 bath cottage styled bungalow", 215000.0, "IA", "for sale", "Cottage Bungalow", "50266", 1, "images/1234olive.jpg" },
                    { 2, "5561 Art Nuevo Ave.", "Sometown", "5 bedroom, 2.5 bath turn of the century deco styled two story", 450000.0, "IA", "for sale", "Deco Two Story", "50266", 1, "images/5561artnuevo.jpg" },
                    { 3, "12 Gravel Rd.", "Ruraltown", "4 bedroom, 2 bath ranch acreage", 385000.0, "IA", "pending", "Ranch Acreage", "50266", 1, "images/12gravel.jpg" },
                    { 4, "321 Corinda St", "Anytown", "2 bedroom, 1.5 bath bungalow", 205000.0, "NY", "for sale", "Two bedroom Bungalow", "12345", 1, "images/321corinda.jpg" },
                    { 5, "756 Lincoln Blvd.", "Metro-City", "3 bedroom, 2 bath Stylish Townhome", 279900.0, "IA", "for sale", "Stylish Townhome", "55555", 1, "images/756lincoln.jpg" },
                    { 6, "5 West Woods Rd", "Anytown", "17 undeveloped acres just west of the city.", 86700.0, "IA", "for sale", "17 acres for development", "55555", 1, "images/5westwoods.jpg" },
                    { 7, "16 East Prosaic St", "Metro-City", "2 bedroom, 2 bath just minutes from downtown.", 199900.0, "IA", "for sale", "Charming home close to downtown", "55555", 1, "images/16east.jpg" }
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
                name: "IX_Properties_RealtorId",
                table: "Properties",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyUsers_UserId",
                table: "PropertyUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyUsers");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Realtors");
        }
    }
}
