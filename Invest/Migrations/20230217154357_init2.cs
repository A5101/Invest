using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Invest.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateIId",
                table: "Favorites",
                newName: "StateId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Favorites",
                newName: "StateIId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "43e037ee-9db2-4121-a95c-d85461526ed8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "96c3845d-9d1e-474d-be4e-dc5150ef561b", "AQAAAAEAACcQAAAAEKo6juTN2nCR2oQulf/9Y4cwW15niAakFaNIbDidE9fksP9BW+iSiL+ZKhGV2LMk+Q==" });
        }
    }
}
