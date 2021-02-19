using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addDeceasedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "BornDate",
                table: "VaultOrder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DiedDate",
                table: "VaultOrder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Salutation",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Suffix",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BornDate",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "DiedDate",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "Salutation",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "Suffix",
                table: "VaultOrder");

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
    }
}
