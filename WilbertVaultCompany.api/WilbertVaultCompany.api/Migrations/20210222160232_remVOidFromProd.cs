using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class remVOidFromProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ProductName",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "VaultOrderId1",
                table: "Cemetary");

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Product",
                type: "int",
                nullable: true);
        }
    }
}
