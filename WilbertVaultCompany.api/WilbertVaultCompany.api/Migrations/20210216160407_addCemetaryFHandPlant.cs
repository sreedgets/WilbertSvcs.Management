using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addCemetaryFHandPlant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Deceased_DeceasedId",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "DeliveringPlant",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "FuneralHome",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "OrderingPlant",
                table: "VaultOrder");

            migrationBuilder.RenameColumn(
                name: "DeceasedId",
                table: "VaultOrder",
                newName: "FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrder_DeceasedId",
                table: "VaultOrder",
                newName: "IX_VaultOrder_FuneralHomeId");

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Plants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId1",
                table: "Plants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VaultOrderId",
                table: "Deceased",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cemetary",
                columns: table => new
                {
                    CemetaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Directions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lattitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Map = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UseCoordinates = table.Column<bool>(type: "bit", nullable: false),
                    VaultOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cemetary", x => x.CemetaryId);
                    table.ForeignKey(
                        name: "FK_Cemetary_VaultOrder_VaultOrderId",
                        column: x => x.VaultOrderId,
                        principalTable: "VaultOrder",
                        principalColumn: "VaultOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plants_VaultOrderId",
                table: "Plants",
                column: "VaultOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_VaultOrderId1",
                table: "Plants",
                column: "VaultOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Deceased_VaultOrderId",
                table: "Deceased",
                column: "VaultOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Cemetary_VaultOrderId",
                table: "Cemetary",
                column: "VaultOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deceased_VaultOrder_VaultOrderId",
                table: "Deceased",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_VaultOrder_VaultOrderId",
                table: "Plants",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_VaultOrder_VaultOrderId1",
                table: "Plants",
                column: "VaultOrderId1",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_FuneralHomes_FuneralHomeId",
                table: "VaultOrder",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deceased_VaultOrder_VaultOrderId",
                table: "Deceased");

            migrationBuilder.DropForeignKey(
                name: "FK_Plants_VaultOrder_VaultOrderId",
                table: "Plants");

            migrationBuilder.DropForeignKey(
                name: "FK_Plants_VaultOrder_VaultOrderId1",
                table: "Plants");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_FuneralHomes_FuneralHomeId",
                table: "VaultOrder");

            migrationBuilder.DropTable(
                name: "Cemetary");

            migrationBuilder.DropIndex(
                name: "IX_Plants_VaultOrderId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_VaultOrderId1",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Deceased_VaultOrderId",
                table: "Deceased");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "VaultOrderId1",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "VaultOrderId",
                table: "Deceased");

            migrationBuilder.RenameColumn(
                name: "FuneralHomeId",
                table: "VaultOrder",
                newName: "DeceasedId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrder_FuneralHomeId",
                table: "VaultOrder",
                newName: "IX_VaultOrder_DeceasedId");

            migrationBuilder.AddColumn<string>(
                name: "DeliveringPlant",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FuneralHome",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderingPlant",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

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
