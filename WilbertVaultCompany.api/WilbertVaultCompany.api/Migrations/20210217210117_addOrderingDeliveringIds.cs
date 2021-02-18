using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addOrderingDeliveringIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveringPlantId",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderingPlantId",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveringPlantId",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "OrderingPlantId",
                table: "VaultOrder");
        }
    }
}
