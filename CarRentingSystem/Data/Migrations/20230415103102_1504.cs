using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentingSystem.Data.Migrations
{
    public partial class _1504 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumer",
                table: "AspNetUsers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumer",
                table: "AspNetUsers");
        }
    }
}
