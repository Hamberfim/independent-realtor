using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "imageUrl",
                table: "Properties",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Properties",
                newName: "imageUrl");
        }
    }
}
