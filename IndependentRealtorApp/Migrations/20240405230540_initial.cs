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
                name: "PublicUsers",
                columns: table => new
                {
                    PublicUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicUserNameEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicUserPassword = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicUsers", x => x.PublicUserId);
                });

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNameEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.RealtorId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyItems",
                columns: table => new
                {
                    PropertyItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyItemAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyItemCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyItemState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyItemZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyItemStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicUserId = table.Column<int>(type: "int", nullable: true),
                    RealtorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyItems", x => x.PropertyItemId);
                    table.ForeignKey(
                        name: "FK_PropertyItems_PublicUsers_PublicUserId",
                        column: x => x.PublicUserId,
                        principalTable: "PublicUsers",
                        principalColumn: "PublicUserId");
                    table.ForeignKey(
                        name: "FK_PropertyItems_Realtors_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "Realtors",
                        principalColumn: "RealtorId");
                });

            migrationBuilder.InsertData(
                table: "PropertyItems",
                columns: new[] { "PropertyItemId", "PropertyItemAddress", "PropertyItemCity", "PropertyItemDescription", "PropertyItemState", "PropertyItemStatus", "PropertyItemTitle", "PropertyItemZip", "PublicUserId", "RealtorId", "imageUrl" },
                values: new object[,]
                {
                    { 1, "123 Oak St", "Somewhere", "Cottage Styled 3 bed, 2 bath, with a 2 car garage.", "IA", "For Sale", "3 bedroom, 2 bath, 2 car garage", "50266", null, null, "images/123oak.jpg" },
                    { 2, "456 Maple Ave", "Somewhere", "Ranch Styled 4 bed, 3 bath, with a 3 car garage.", "IA", "Pending", "4 bed, 3 bath, 3 car garage", "50266", null, null, "images/456maple.jpg" },
                    { 3, "789 Elm St", "Somewhere", "Two Story 4 bed, 2.5 bath, with a car port and large back yard.", "IA", "For Sale", "4 bed, 2.5 bath", "50266", null, null, "images/789elm.jpg" },
                    { 4, "812 gravel Rd", "Ruraltown", "Farm home 3 bed, 2 bath, on an acreage.", "IA", "For Sale", "3 bed, 1.5 bath on an acreage.", "50266", null, null, "images/812gravel.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "RealtorId", "FirstName", "LastName", "Password", "UserNameEmail", "imageUrl" },
                values: new object[] { 1, "Timothy", "Goodsale", "password", "tgoodsale@fakerealty.com", "images/tgoodsale.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyItems_PublicUserId",
                table: "PropertyItems",
                column: "PublicUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyItems_RealtorId",
                table: "PropertyItems",
                column: "RealtorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyItems");

            migrationBuilder.DropTable(
                name: "PublicUsers");

            migrationBuilder.DropTable(
                name: "Realtors");
        }
    }
}
