using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CostCadastr",
                table: "RealEstates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Liquid",
                table: "RealEstates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "RealEstates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Risks",
                table: "RealEstates",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ca00ea60-4d8c-4ba3-9ca1-77624a48a733");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44546e06-8719-4ad8-b88a-f271ae9d6eac", "a011100e-4260-489e-86f6-2d0022290b42", "rieltor", "RIELTOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb01dd14-501b-4d05-923a-a39f3c96ecb4", "AQAAAAEAACcQAAAAENcqIGyjZRWJ0f2vXyo97AJsf56pCeK5d35hZzQNwMmJEhwqxnJ0necsFNN5lqCJPw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eac");

            migrationBuilder.DropColumn(
                name: "CostCadastr",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Liquid",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Risks",
                table: "RealEstates");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "9cbf8456-6359-422f-97f7-6f1dc7982c5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fb0b1ed-0c4a-40bd-b19e-8e0821f74703", "AQAAAAEAACcQAAAAEC3Zl6qQLdOXP3N+O4ZFz/XaeEfgiUxt2tDGXQWt4+7ts5jln/w5qvPbQ2jaXsNkxA==" });
        }
    }
}
