using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class modifyPlants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone1",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType1",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType2",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone1",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "PhoneType1",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "PhoneType2",
                table: "Plants");
        }
    }
}
