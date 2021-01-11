using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactName",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FuneralHomeContactId",
                table: "FuneralHomes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone1",
                table: "FuneralHomeContacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "FuneralHomeContacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone3",
                table: "FuneralHomeContacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType1",
                table: "FuneralHomeContacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType2",
                table: "FuneralHomeContacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType3",
                table: "FuneralHomeContacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FuneralHomeContacts_FuneralHomeId",
                table: "FuneralHomeContacts",
                column: "FuneralHomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomeContacts_FuneralHomes_FuneralHomeId",
                table: "FuneralHomeContacts",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomeContacts_FuneralHomes_FuneralHomeId",
                table: "FuneralHomeContacts");

            migrationBuilder.DropIndex(
                name: "IX_FuneralHomeContacts_FuneralHomeId",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "ContactName",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "FuneralHomeContactId",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "Phone1",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "Phone3",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "PhoneType1",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "PhoneType2",
                table: "FuneralHomeContacts");

            migrationBuilder.DropColumn(
                name: "PhoneType3",
                table: "FuneralHomeContacts");
        }
    }
}
