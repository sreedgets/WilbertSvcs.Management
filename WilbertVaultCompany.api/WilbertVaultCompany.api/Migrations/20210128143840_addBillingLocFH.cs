using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addBillingLocFH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillingAddress",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingCity",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingState",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingZipCode",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingAddress",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "BillingCity",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "BillingState",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "BillingZipCode",
                table: "FuneralHomes");
        }
    }
}
