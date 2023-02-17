using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Usage",
                table: "RealEstates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "RealEstates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "RealEstates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Isrepaired",
                table: "RealEstates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RepairedType",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4bb0485b-93cb-45c8-8362-7efba962400d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "99779059-67dd-4eba-b1dc-e24c377cc596", true, "AQAAAAEAACcQAAAAEGDTb2LRh1IbDPZkPGIO6zE2LLOhNNWDe9XlVWCzfoi0ZEh5ARIr2DcOisYPqnVkrA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Isrepaired",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "RepairedType",
                table: "RealEstates");

            migrationBuilder.AlterColumn<string>(
                name: "Usage",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "36129c3a-2048-4e39-a7be-e4bfab17da77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "19a4977c-a20c-4d7f-ac3a-0c569c21bc26", false, "AQAAAAEAACcQAAAAEK4KTaJ68/wLyg0A09h2qlP6Obf6KplHFzrNXMVzJx6ehfPXHFWMwRFvDEQqXZPbYA==" });
        }
    }
}
