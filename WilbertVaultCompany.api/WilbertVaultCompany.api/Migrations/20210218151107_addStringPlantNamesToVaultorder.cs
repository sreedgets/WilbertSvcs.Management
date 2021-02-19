using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addStringPlantNamesToVaultorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveringPlantName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderingPlantName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveringPlantName",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "OrderingPlantName",
                table: "VaultOrder");
        }
    }
}
