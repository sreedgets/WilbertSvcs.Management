using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertFSvcs.api.Migrations
{
    public partial class createNewStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photos",
                table: "FuneralHomeContact");

            migrationBuilder.AddColumn<string>(
                name: "TruckId",
                table: "Photo",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "FuneralHomeContact",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllowedToSelect",
                columns: table => new
                {
                    AllowedToSelectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaultId = table.Column<int>(nullable: false),
                    FullAccess = table.Column<bool>(nullable: false),
                    FuneralHomes = table.Column<bool>(nullable: false),
                    Drivers = table.Column<bool>(nullable: false),
                    PlantManagers = table.Column<bool>(nullable: false),
                    OfficeStaff = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedToSelect", x => x.AllowedToSelectId);
                });

            migrationBuilder.CreateTable(
                name: "Cemetary",
                columns: table => new
                {
                    CemetaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    County = table.Column<string>(nullable: true),
                    Directions = table.Column<string>(nullable: true),
                    Lattitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Map = table.Column<byte[]>(nullable: true),
                    UseCoordinates = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cemetary", x => x.CemetaryId);
                });

            migrationBuilder.CreateTable(
                name: "Deceased",
                columns: table => new
                {
                    DeceasedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    suffix = table.Column<int>(nullable: false),
                    BornDate = table.Column<DateTime>(nullable: false),
                    DiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deceased", x => x.DeceasedId);
                });

            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    TruckId = table.Column<string>(nullable: false),
                    AcquisitionDate = table.Column<DateTime>(nullable: false),
                    PlantId = table.Column<int>(nullable: false),
                    DriverEmployeeId = table.Column<int>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    RegCounty = table.Column<string>(nullable: true),
                    VIN = table.Column<string>(nullable: true),
                    Tonnage = table.Column<int>(nullable: false),
                    LicPlateRenewal = table.Column<int>(nullable: false),
                    RegFee = table.Column<decimal>(nullable: false),
                    TruckNumber = table.Column<long>(nullable: false),
                    Inactive = table.Column<bool>(nullable: false),
                    InactiveReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.TruckId);
                    table.ForeignKey(
                        name: "FK_Truck_Employee_DriverEmployeeId",
                        column: x => x.DriverEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Truck_Plant_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vault",
                columns: table => new
                {
                    VaultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Ovation = table.Column<bool>(nullable: false),
                    Decoration = table.Column<bool>(nullable: false),
                    Legacy = table.Column<bool>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    VaultCode = table.Column<string>(nullable: true),
                    AllowedToSelectId = table.Column<int>(nullable: false),
                    UpChargeForLegacy = table.Column<bool>(nullable: false),
                    UpChargeAmount = table.Column<decimal>(nullable: false),
                    VaultCategory = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Color1 = table.Column<string>(nullable: true),
                    Color2 = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    PhotoImage = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vault", x => x.VaultId);
                    table.ForeignKey(
                        name: "FK_Vault_AllowedToSelect_AllowedToSelectId",
                        column: x => x.AllowedToSelectId,
                        principalTable: "AllowedToSelect",
                        principalColumn: "AllowedToSelectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaultOrder",
                columns: table => new
                {
                    VaultOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuneralDate = table.Column<DateTime>(nullable: false),
                    FuneralTime = table.Column<DateTime>(nullable: false),
                    CemetaryTime = table.Column<DateTime>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    OrderingPlant = table.Column<string>(nullable: true),
                    DeliveringPlant = table.Column<string>(nullable: true),
                    funeralHome = table.Column<string>(nullable: true),
                    newFuneralHome = table.Column<string>(nullable: true),
                    funeralDirector = table.Column<string>(nullable: true),
                    newFuneralDirector = table.Column<string>(nullable: true),
                    CemetaryId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    theDeceasedDeceasedId = table.Column<int>(nullable: true),
                    category = table.Column<int>(nullable: false),
                    VaultId = table.Column<int>(nullable: true),
                    VenetianCarapace = table.Column<int>(nullable: false),
                    TentWith6Chairs = table.Column<bool>(nullable: false),
                    ExtraChairs = table.Column<int>(nullable: false),
                    RegisterStand = table.Column<bool>(nullable: false),
                    MilitarySetup = table.Column<bool>(nullable: false),
                    AwningOverCasket = table.Column<bool>(nullable: false),
                    FDRequest = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PlantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaultOrder", x => x.VaultOrderId);
                    table.ForeignKey(
                        name: "FK_VaultOrder_Cemetary_CemetaryId",
                        column: x => x.CemetaryId,
                        principalTable: "Cemetary",
                        principalColumn: "CemetaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaultOrder_Plant_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VaultOrder_Vault_VaultId",
                        column: x => x.VaultId,
                        principalTable: "Vault",
                        principalColumn: "VaultId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VaultOrder_Deceased_theDeceasedDeceasedId",
                        column: x => x.theDeceasedDeceasedId,
                        principalTable: "Deceased",
                        principalColumn: "DeceasedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    DeliveryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuneralDate = table.Column<DateTime>(nullable: false),
                    OrderingPlant = table.Column<string>(nullable: true),
                    DeliveringPlant = table.Column<string>(nullable: true),
                    VaultOrderId = table.Column<int>(nullable: false),
                    FuneralHome = table.Column<string>(nullable: true),
                    Cemetary = table.Column<string>(nullable: true),
                    FuneralDirector = table.Column<string>(nullable: true),
                    GravesideTime = table.Column<DateTime>(nullable: false),
                    DeceasedId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Driver = table.Column<string>(nullable: true),
                    Truck = table.Column<string>(nullable: true),
                    AmtPaid = table.Column<decimal>(nullable: false),
                    PaidTo = table.Column<string>(nullable: true),
                    TruckNum = table.Column<int>(nullable: false),
                    EquipInNeedOfRepair = table.Column<string>(nullable: true),
                    ReadyOnTime = table.Column<bool>(nullable: false),
                    AwningSet = table.Column<bool>(nullable: false),
                    EquipPolished = table.Column<bool>(nullable: false),
                    UniformClean = table.Column<bool>(nullable: false),
                    TentSet = table.Column<bool>(nullable: false),
                    ChairsSet = table.Column<bool>(nullable: false),
                    SideWalls = table.Column<bool>(nullable: false),
                    OilTiresChecked = table.Column<bool>(nullable: false),
                    ReasonTentNotSet = table.Column<string>(nullable: true),
                    FDArrivalTime = table.Column<string>(nullable: true),
                    FDCommentsAndRemarks = table.Column<string>(nullable: true),
                    TimeLeftPlant = table.Column<DateTime>(nullable: false),
                    MilesTo = table.Column<int>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    SetupTime = table.Column<DateTime>(nullable: false),
                    ReturnTimeInMinutes = table.Column<int>(nullable: false),
                    TimeIn_Plant = table.Column<DateTime>(nullable: false),
                    RemarksOrProblems = table.Column<string>(nullable: true),
                    ReviewedByOffice = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.DeliveryId);
                    table.ForeignKey(
                        name: "FK_Delivery_Deceased_DeceasedId",
                        column: x => x.DeceasedId,
                        principalTable: "Deceased",
                        principalColumn: "DeceasedId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Delivery_VaultOrder_VaultOrderId",
                        column: x => x.VaultOrderId,
                        principalTable: "VaultOrder",
                        principalColumn: "VaultOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_TruckId",
                table: "Photo",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_DeceasedId",
                table: "Delivery",
                column: "DeceasedId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_VaultOrderId",
                table: "Delivery",
                column: "VaultOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Truck_DriverEmployeeId",
                table: "Truck",
                column: "DriverEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Truck_PlantId",
                table: "Truck",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Vault_AllowedToSelectId",
                table: "Vault",
                column: "AllowedToSelectId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_CemetaryId",
                table: "VaultOrder",
                column: "CemetaryId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_PlantId",
                table: "VaultOrder",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_VaultId",
                table: "VaultOrder",
                column: "VaultId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_theDeceasedDeceasedId",
                table: "VaultOrder",
                column: "theDeceasedDeceasedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Truck_TruckId",
                table: "Photo",
                column: "TruckId",
                principalTable: "Truck",
                principalColumn: "TruckId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Truck_TruckId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "Truck");

            migrationBuilder.DropTable(
                name: "VaultOrder");

            migrationBuilder.DropTable(
                name: "Cemetary");

            migrationBuilder.DropTable(
                name: "Vault");

            migrationBuilder.DropTable(
                name: "Deceased");

            migrationBuilder.DropTable(
                name: "AllowedToSelect");

            migrationBuilder.DropIndex(
                name: "IX_Photo_TruckId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "TruckId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "FuneralHomeContact");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photos",
                table: "FuneralHomeContact",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
