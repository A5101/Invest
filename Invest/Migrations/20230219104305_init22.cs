using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1ce07b64-0354-43dc-bde9-f1faeefb2fbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac",
                column: "ConcurrencyStamp",
                value: "f81bb6b3-78ca-44f8-b645-f64ff2b04bc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6ead",
                column: "ConcurrencyStamp",
                value: "7a9285e9-dc88-4392-9746-76c4ccc596e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f1b5336-8d1e-43fa-9daa-bd396217efb2", "AQAAAAEAACcQAAAAELcctPmDKqrlaS/SmJ7AXfoEj32Y6QY9Rxv16YRjJxEqhc/zROGk8KPBJc3ZnYFezw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1536aa22-dca5-42c1-a6f3-fc95562ffbb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac",
                column: "ConcurrencyStamp",
                value: "606eabb3-d42b-4208-b9db-b798027be773");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6ead",
                column: "ConcurrencyStamp",
                value: "1e49691a-4907-43ee-bd89-c9aab6253099");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc2b528e-c74a-40f9-8e55-e21895b3761f", "AQAAAAEAACcQAAAAEPIOZW3aVJeU1hJUWYPhoKWYT8TuAgxDT+yAr3ObVqSVP3/0h+PvMaXQxuF2FAc9gA==" });
        }
    }
}
