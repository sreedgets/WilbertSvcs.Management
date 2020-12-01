using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class chgFuneralHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneType2",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneType1",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ParentFuneralHomeId",
                table: "FuneralHomes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ParentFunrealHomeFuneralHomeId",
                table: "FuneralHomes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FuneralHomes_ParentFunrealHomeFuneralHomeId",
                table: "FuneralHomes",
                column: "ParentFunrealHomeFuneralHomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomes_FuneralHomes_ParentFunrealHomeFuneralHomeId",
                table: "FuneralHomes",
                column: "ParentFunrealHomeFuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomes_FuneralHomes_ParentFunrealHomeFuneralHomeId",
                table: "FuneralHomes");

            migrationBuilder.DropIndex(
                name: "IX_FuneralHomes_ParentFunrealHomeFuneralHomeId",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "ParentFunrealHomeFuneralHomeId",
                table: "FuneralHomes");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneType2",
                table: "FuneralHomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneType1",
                table: "FuneralHomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParentFuneralHomeId",
                table: "FuneralHomes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
