using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c8695fb1-9cb9-4f58-8b5c-b2d1349519ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac",
                column: "ConcurrencyStamp",
                value: "9c9115c7-0c8d-48c6-81e5-f7a4bf325094");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6ead", "95efc460-0b48-4486-8a40-07b8a9b949cb", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2e22c45-3138-4a34-950b-c18560263c65", "AQAAAAEAACcQAAAAELgpcMWsnWDKXFWC9ohjETm9nMKP6RHEOh0NgM/tXRHXWuYGLT7I9CiowVqKGUhtow==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6ead");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "2dabe66f-5ec3-4d0e-9380-07c83799fc87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac",
                column: "ConcurrencyStamp",
                value: "2770a197-bb1b-4eff-9c55-b728c6cf1973");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad82bf18-4993-4c55-8c7d-e5ae8ca2134d", "AQAAAAEAACcQAAAAEC3r0yy4BMt9FtR8zJZjzqpT1QjlZ7TIpVDRO6viTrCqpqw70puWHDJ8KzYG+heNxw==" });
        }
    }
}
