using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addDeceasedclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeceasedId",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_DeceasedId",
                table: "VaultOrder",
                column: "DeceasedId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_Deceased_DeceasedId",
                table: "VaultOrder",
                column: "DeceasedId",
                principalTable: "Deceased",
                principalColumn: "DeceasedId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Deceased_DeceasedId",
                table: "VaultOrder");

            migrationBuilder.DropIndex(
                name: "IX_VaultOrder_DeceasedId",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "DeceasedId",
                table: "VaultOrder");
        }
    }
}
