using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Raiting",
                table: "RealEstates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19a4977c-a20c-4d7f-ac3a-0c569c21bc26", "AQAAAAEAACcQAAAAEK4KTaJ68/wLyg0A09h2qlP6Obf6KplHFzrNXMVzJx6ehfPXHFWMwRFvDEQqXZPbYA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raiting",
                table: "RealEstates");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "b3ad9079-61af-444f-b761-e8af9a175aea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7b89cf3-8dfd-4fc2-b3b6-bc9927b2e0a6", "AQAAAAEAACcQAAAAECOyKMWBwtAirtEyyihTCzgcz6SRbwN1tg0k/JoS2aYAV3KplSSKpJvpk9XvOuw3Pg==" });
        }
    }
}
