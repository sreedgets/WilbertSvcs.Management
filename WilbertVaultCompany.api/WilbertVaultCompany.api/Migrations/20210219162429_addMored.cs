using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addMored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_FuneralHomes_FuneralHomeId",
                table: "VaultOrder");

            migrationBuilder.DropIndex(
                name: "IX_VaultOrder_FuneralHomeId",
                table: "VaultOrder");

            migrationBuilder.RenameColumn(
                name: "NewFuneralHome",
                table: "VaultOrder",
                newName: "funeralhome");

            migrationBuilder.RenameColumn(
                name: "NewFuneralDirector",
                table: "VaultOrder",
                newName: "CemetaryName");

            migrationBuilder.AddColumn<int>(
                name: "FuneralHomeContactId",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "FuneralHomeContacts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Cemetary",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FuneralHomeContacts_VaultOrderId",
                table: "FuneralHomeContacts",
                column: "VaultOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cemetary_VaultOrderId",
                table: "Cemetary",
                column: "VaultOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cemetary_VaultOrder_VaultOrderId",
                table: "Cemetary",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomeContacts_VaultOrder_VaultOrderId",
                table: "FuneralHomeContacts",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cemetary_VaultOrder_VaultOrderId",
                table: "Cemetary");

            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomeContacts_VaultOrder_VaultOrderId",
                table: "FuneralHomeContacts");

            migrationBuilder.DropIndex(
                name: "IX_FuneralHomeContacts_VaultOrderId",
                table: "FuneralHomeContacts");

            migrationBuilder.DropIndex(
                name: "IX_Cemetary_VaultOrderId",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "FuneralHomeContactId",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Cemetary");

            migrationBuilder.RenameColumn(
                name: "funeralhome",
                table: "VaultOrder",
                newName: "NewFuneralHome");

            migrationBuilder.RenameColumn(
                name: "CemetaryName",
                table: "VaultOrder",
                newName: "NewFuneralDirector");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_FuneralHomeId",
                table: "VaultOrder",
                column: "FuneralHomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_FuneralHomes_FuneralHomeId",
                table: "VaultOrder",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
