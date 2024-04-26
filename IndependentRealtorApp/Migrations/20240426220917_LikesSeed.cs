using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class LikesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "80ef1413-b6ce-4afc-af73-d228704d7038");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d29d0be7-c716-407f-b562-81132f0fa182");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1ceabda3-40de-4e0f-99dc-f9af54e1eef9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "3ea335dc-8bc7-4a89-884f-a2943cb9d8f8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e2d074bd-b9a0-47af-a838-3d2244d1a641");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "13d3a4eb-7bda-4527-a626-f269d784f380");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "146e29dd-9a41-4fcc-ac77-91cee7b8ca67");

            migrationBuilder.InsertData(
                table: "PropertyUsers",
                columns: new[] { "PropertyId", "PublicUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d75efb56-3f70-478c-b255-cc81ec17bae8");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0b005b89-be18-46e7-a27c-49391be2610b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "deccdf89-495a-49b8-ba29-10e8d72e9af5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "f3d0deb3-497e-47f5-9b01-5248065ace8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6bb2744f-0f2b-4bdb-ad83-b248de1542d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "e6aec2f2-6b52-4a64-9bd9-35335e40c77c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "127f41cd-f4aa-4c22-b608-74b932c53a04");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "b4ce4434-83c4-425d-9e27-6d231c14b8ac");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8576a48c-baf9-4546-b8dc-4fc4831bd197");
        }
    }
}
