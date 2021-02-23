using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class remProdIdFromVO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cemetary_VaultOrder_VaultOrderId1",
                table: "Cemetary");

            migrationBuilder.DropIndex(
                name: "IX_Cemetary_VaultOrderId1",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "VaultOrderId1",
                table: "Cemetary");

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_VaultOrderId",
                table: "Product",
                column: "VaultOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_VaultOrder_VaultOrderId",
                table: "Product",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_VaultOrder_VaultOrderId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_VaultOrderId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId1",
                table: "Cemetary",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cemetary_VaultOrderId1",
                table: "Cemetary",
                column: "VaultOrderId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cemetary_VaultOrder_VaultOrderId1",
                table: "Cemetary",
                column: "VaultOrderId1",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
