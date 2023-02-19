using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerName",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BuildEndDate",
                table: "RealEstates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "BuildStartDate",
                table: "RealEstates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "BuyCost",
                table: "RealEstates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BuyDate",
                table: "RealEstates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "874100c5-67ad-444b-9d5f-4bfb5cc1d336");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac",
                column: "ConcurrencyStamp",
                value: "e8dcc497-ec11-402b-9e0d-108522d7249d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6ead",
                column: "ConcurrencyStamp",
                value: "4e1044b2-26cf-4749-b06f-348c47983bd7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac054896-bc0b-4418-86dd-7ecdd9221d3c", "AQAAAAEAACcQAAAAEC2X5EZSw7ghyF5oYKgI1LCkzQJQFJJK6XrQFxzsOYsp58ByamISS2LkrQAmodbfUg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuildEndDate",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "BuildStartDate",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "BuyCost",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "BuyDate",
                table: "RealEstates");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerName",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6ead",
                column: "ConcurrencyStamp",
                value: "95efc460-0b48-4486-8a40-07b8a9b949cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2e22c45-3138-4a34-950b-c18560263c65", "AQAAAAEAACcQAAAAELgpcMWsnWDKXFWC9ohjETm9nMKP6RHEOh0NgM/tXRHXWuYGLT7I9CiowVqKGUhtow==" });
        }
    }
}
