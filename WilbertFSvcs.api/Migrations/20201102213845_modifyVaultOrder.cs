using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertFSvcs.api.Migrations
{
    public partial class modifyVaultOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Deceased_theDeceasedDeceasedId",
                table: "VaultOrder");

            migrationBuilder.DropIndex(
                name: "IX_VaultOrder_theDeceasedDeceasedId",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "theDeceasedDeceasedId",
                table: "VaultOrder");

            migrationBuilder.AddColumn<int>(
                name: "DeceasedId",
                table: "VaultOrder",
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
                onDelete: ReferentialAction.NoAction);
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

            migrationBuilder.AddColumn<int>(
                name: "theDeceasedDeceasedId",
                table: "VaultOrder",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_theDeceasedDeceasedId",
                table: "VaultOrder",
                column: "theDeceasedDeceasedId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_Deceased_theDeceasedDeceasedId",
                table: "VaultOrder",
                column: "theDeceasedDeceasedId",
                principalTable: "Deceased",
                principalColumn: "DeceasedId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
