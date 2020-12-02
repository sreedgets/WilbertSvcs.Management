using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addParentFuneralHomeClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ParentFuneralHome",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parent_funeralhome_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    funral_homeFuneralHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentFuneralHome", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParentFuneralHome_FuneralHomes_funral_homeFuneralHomeId",
                        column: x => x.funral_homeFuneralHomeId,
                        principalTable: "FuneralHomes",
                        principalColumn: "FuneralHomeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentFuneralHome_funral_homeFuneralHomeId",
                table: "ParentFuneralHome",
                column: "funral_homeFuneralHomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentFuneralHome");

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
    }
}
