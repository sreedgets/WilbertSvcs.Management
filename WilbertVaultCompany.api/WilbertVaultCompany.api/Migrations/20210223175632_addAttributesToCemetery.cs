using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addAttributesToCemetery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CemetaryId",
                table: "Plants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Cemetary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone1",
                table: "Cemetary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType1",
                table: "Cemetary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "Cemetary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PlantName",
                table: "Cemetary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plants_CemetaryId",
                table: "Plants",
                column: "CemetaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Cemetary_CemetaryId",
                table: "Plants",
                column: "CemetaryId",
                principalTable: "Cemetary",
                principalColumn: "CemetaryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Cemetary_CemetaryId",
                table: "Plants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_CemetaryId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "CemetaryId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "Phone1",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "PhoneType1",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "Cemetary");

            migrationBuilder.DropColumn(
                name: "PlantName",
                table: "Cemetary");
        }
    }
}
