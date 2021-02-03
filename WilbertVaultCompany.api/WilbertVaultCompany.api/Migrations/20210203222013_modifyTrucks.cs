using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class modifyTrucks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropColumn(
                name: "PlantName",
                table: "Truck");

            migrationBuilder.CreateIndex(
                name: "IX_Truck_PlantId",
                table: "Truck",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Truck_Plants_PlantId",
                table: "Truck",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Truck_Plants_PlantId",
                table: "Truck");

            migrationBuilder.DropIndex(
                name: "IX_Truck_PlantId",
                table: "Truck");

            migrationBuilder.AddColumn<string>(
                name: "PlantName",
                table: "Truck",
                type: "nvarchar(max)",
                nullable: true);

        }
    }
}
