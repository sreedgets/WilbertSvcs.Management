using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addVaultOrdersAndDeceased : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deceased",
                columns: table => new
                {
                    DeceasedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suffix = table.Column<int>(type: "int", nullable: false),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deceased", x => x.DeceasedId);
                });

            migrationBuilder.CreateTable(
                name: "VaultOrder",
                columns: table => new
                {
                    VaultOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuneralDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FuneralTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CemetaryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: false),
                    OrderingPlant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveringPlant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuneralHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewFuneralHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuneralDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewFuneralDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CemetaryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    VaultId = table.Column<int>(type: "int", nullable: true),
                    VenetianCarapace = table.Column<int>(type: "int", nullable: false),
                    TentWith6Chairs = table.Column<bool>(type: "bit", nullable: false),
                    ExtraChairs = table.Column<int>(type: "int", nullable: false),
                    RegisterStand = table.Column<bool>(type: "bit", nullable: false),
                    MilitarySetup = table.Column<bool>(type: "bit", nullable: false),
                    AwningOverCasket = table.Column<bool>(type: "bit", nullable: false),
                    Fdrequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantId = table.Column<int>(type: "int", nullable: true),
                    DeceasedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaultOrder", x => x.VaultOrderId);
                    table.ForeignKey(
                        name: "FK_VaultOrder_Deceased_DeceasedId",
                        column: x => x.DeceasedId,
                        principalTable: "Deceased",
                        principalColumn: "DeceasedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_DeceasedId",
                table: "VaultOrder",
                column: "DeceasedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaultOrder");

            migrationBuilder.DropTable(
                name: "Deceased");
        }
    }
}
