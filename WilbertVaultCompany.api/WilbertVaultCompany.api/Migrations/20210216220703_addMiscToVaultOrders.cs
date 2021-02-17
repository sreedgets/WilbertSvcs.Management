using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addMiscToVaultOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cemetary_VaultOrder_VaultOrderId",
                table: "Cemetary");

            migrationBuilder.DropForeignKey(
                name: "FK_Deceased_VaultOrder_VaultOrderId",
                table: "Deceased");

            migrationBuilder.DropIndex(
                name: "IX_Deceased_VaultOrderId",
                table: "Deceased");

            migrationBuilder.DropIndex(
                name: "IX_Cemetary_VaultOrderId",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "FuneralTime",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Deceased");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Cemetary");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "GraveLocationSection",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraveLocationSection",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "VaultOrder");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Location",
                table: "VaultOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FuneralTime",
                table: "VaultOrder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Deceased",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Cemetary",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deceased_VaultOrderId",
                table: "Deceased",
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
                name: "FK_Deceased_VaultOrder_VaultOrderId",
                table: "Deceased",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
