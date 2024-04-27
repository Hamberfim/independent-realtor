using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndependentRealtorApp.Migrations
{
    /// <inheritdoc />
    public partial class RealtorAsUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "UserName", "UserPassword" },
                values: new object[] { "fcd21695-3756-4c29-af9d-ecd8b6ac159a", "tgoodsale@fakerealty.com", "Timothy", "Goodsale", "Tim", "pass2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "596a738a-f093-45df-b4a2-e544c243f103");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "de262cde-0744-45dd-9827-adbb47405d15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "6f5f4d9b-4488-43f9-a2c6-cc09f34cc2bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "cf8ede18-c017-44bb-a06b-ec9c708b54a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "201c38b7-bbfa-4a62-8ea3-a7a5f5482e8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "80b7e1cb-0904-4ccc-b75e-1425a7934101");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4eb8312f-609b-484a-97d0-98036dda3f4b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "UserName", "UserPassword" },
                values: new object[] { "da1530e9-36bd-45a6-bbc1-28cffa963630", "ssmith@fakeworld.net", "Sam", "Smith", "Sam", "pass1" });

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

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0f57636f-a722-4597-855e-9575e82a6d2b");
        }
    }
}
