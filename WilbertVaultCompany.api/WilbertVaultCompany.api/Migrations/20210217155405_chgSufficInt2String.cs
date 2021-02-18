using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class chgSufficInt2String : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Suffix",
                table: "Deceased",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Deceased",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Deceased");

            migrationBuilder.AlterColumn<int>(
                name: "Suffix",
                table: "Deceased",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
