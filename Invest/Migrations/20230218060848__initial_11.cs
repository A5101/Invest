using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class _initial_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Favorites");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Favorites",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "8b43bcb0-8624-4f5e-82f1-ca7689183d3e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57f65acb-aa12-462a-9d33-c3488a961340", "AQAAAAEAACcQAAAAEH3mOC0hLJRcNZFoMqTz9OMbX62KEoPPgtkpE6sDjlXX5UalKT9RkwxZtRDBVFjoJg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Favorites");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Favorites",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
