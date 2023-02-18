using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ca00ea60-4d8c-4ba3-9ca1-77624a48a733");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac",
                column: "ConcurrencyStamp",
                value: "a011100e-4260-489e-86f6-2d0022290b42");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb01dd14-501b-4d05-923a-a39f3c96ecb4", "AQAAAAEAACcQAAAAENcqIGyjZRWJ0f2vXyo97AJsf56pCeK5d35hZzQNwMmJEhwqxnJ0necsFNN5lqCJPw==" });
        }
    }
}
