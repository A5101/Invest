using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "HistoryPrices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoryPrices",
                table: "HistoryPrices",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "0ec1c7d9-8ddb-4bfc-86fc-6140138d7703");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1977254b-e647-4698-b78a-f0d2ab0fd69a", "AQAAAAEAACcQAAAAEBdRbBN+D1xkuiI+RBNVy9KN3E7dQdC1i6RQ8qs7sIGFkg4TQqinxpwHXnX0PWw7Bw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoryPrices",
                table: "HistoryPrices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HistoryPrices");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "4c714ec2-0276-43cf-a509-8fcfa37ce47e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06403a86-578a-496b-9223-e2a8ded6d74f", "AQAAAAEAACcQAAAAEHE1K6euV4V6dTn1upSmbIXBAuaTmzV4ybPxZFA/z7Gu3DQyeaUZup4SM2OBUSGNsg==" });
        }
    }
}
