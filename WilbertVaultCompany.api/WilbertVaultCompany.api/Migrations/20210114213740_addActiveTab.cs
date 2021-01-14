using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addActiveTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveTab",
                table: "FuneralHomes");

            migrationBuilder.AddColumn<int>(
                name: "ActiveTab",
                table: "FuneralHomeContacts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveTab",
                table: "FuneralHomeContacts");

            migrationBuilder.AddColumn<int>(
                name: "ActiveTab",
                table: "FuneralHomes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
