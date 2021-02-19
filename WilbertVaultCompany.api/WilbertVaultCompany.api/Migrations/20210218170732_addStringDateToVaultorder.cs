using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addStringDateToVaultorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "strCemeteryTime",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "strFuneralDate",
                table: "VaultOrder",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "strCemeteryTime",
                table: "VaultOrder");

            migrationBuilder.DropColumn(
                name: "strFuneralDate",
                table: "VaultOrder");
        }
    }
}
