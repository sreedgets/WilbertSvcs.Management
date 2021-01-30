using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addTruckList2Plants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Truck_TruckId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_TruckId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "TruckId",
                table: "Plants");

            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "Plants");

            migrationBuilder.AddColumn<string>(
                name: "TruckId",
                table: "Plants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plants_TruckId",
                table: "Plants",
                column: "TruckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Truck_TruckId",
                table: "Plants",
                column: "TruckId",
                principalTable: "Truck",
                principalColumn: "TruckId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
