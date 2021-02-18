using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addFuneralHomeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "FuneralHomes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FuneralHomes_VaultOrderId",
                table: "FuneralHomes",
                column: "VaultOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomes_VaultOrder_VaultOrderId",
                table: "FuneralHomes",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomes_VaultOrder_VaultOrderId",
                table: "FuneralHomes");

            migrationBuilder.DropIndex(
                name: "IX_FuneralHomes_VaultOrderId",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "FuneralHomes");
        }
    }
}
