using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "e220b11f-9fee-4897-9421-01401a7018da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47ecf6cc-b1e7-4179-bf0f-cdbfed271a76", "AQAAAAEAACcQAAAAEOiaIo8a/yh21EEmCQZBqDYSoi959L7U95LbddSah0B/81H1i2kFp6c1xOEvmG/6ew==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "8b9d1158-179d-436e-a532-7fbea19cc442");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdf22d8d-37a4-4ca2-bcdc-75e836e51d59", "AQAAAAEAACcQAAAAEHc+kYjwzwMZuRBNWgDiM9QDcD77fPE/IK5RqRXRkLRSZoDxY9uPXrnxrpkrfO92gQ==" });
        }
    }
}
