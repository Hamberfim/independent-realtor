using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class FullSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "da1530e9-36bd-45a6-bbc1-28cffa963630");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e6d345be-9bae-4991-8eb8-2838af892779");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2e68aea5-2909-4f9e-9db8-4c6472985b4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9fd832ff-db1d-41fb-8168-70a7c11cca73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4b8ec8e6-8e0a-4325-a076-03bcb80f0049");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "3b2dc22b-855c-44da-a8bc-ba444fe7faa7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "4b418baa-1af7-49df-897d-a3883ee6cfa8");

            migrationBuilder.InsertData(
                table: "PropertyUsers",
                columns: new[] { "PropertyId", "PublicUserId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 7, 1 },
                    { 1, 2 },
                    { 6, 2 },
                    { 2, 3 },
                    { 5, 3 },
                    { 3, 4 },
                    { 6, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 4, 6 },
                    { 3, 7 },
                    { 7, 7 }
                });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0f57636f-a722-4597-855e-9575e82a6d2b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "PropertyUsers",
                keyColumns: new[] { "PropertyId", "PublicUserId" },
                keyValues: new object[] { 7, 7 });

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

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d75efb56-3f70-478c-b255-cc81ec17bae8");
        }
    }
}
