using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addPlantListtoTruck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
