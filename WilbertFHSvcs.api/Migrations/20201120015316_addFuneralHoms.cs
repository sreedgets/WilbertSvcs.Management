using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertFHSvcs.api.Migrations
{
    public partial class addFuneralHoms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllowedToSelect",
                columns: table => new
                {
                    AllowedToSelectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaultId = table.Column<int>(type: "int", nullable: false),
                    FullAccess = table.Column<bool>(type: "bit", nullable: false),
                    FuneralHomes = table.Column<bool>(type: "bit", nullable: false),
                    Drivers = table.Column<bool>(type: "bit", nullable: false),
                    PlantManagers = table.Column<bool>(type: "bit", nullable: false),
                    OfficeStaff = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedToSelect", x => x.AllowedToSelectId);
                });

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
                    UseCoordinates = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cemetary", x => x.CemetaryId);
                });

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
                    suffix = table.Column<int>(type: "int", nullable: false),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deceased", x => x.DeceasedId);
                });

            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantManagerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintCompletedOrders = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "Vault",
                columns: table => new
                {
                    VaultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ovation = table.Column<bool>(type: "bit", nullable: false),
                    Decoration = table.Column<bool>(type: "bit", nullable: false),
                    Legacy = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VaultCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedToSelectId = table.Column<int>(type: "int", nullable: false),
                    UpChargeForLegacy = table.Column<bool>(type: "bit", nullable: false),
                    UpChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VaultCategory = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    Color1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
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
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    CanDoFollowUps = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    PhotoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Plant_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FuneralHome",
                columns: table => new
                {
                    FuneralHomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentFuneralHomeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuneralHome", x => x.FuneralHomeId);
                    table.ForeignKey(
                        name: "FK_FuneralHome_Plant_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Cascade);
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
                    funeralHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newFuneralHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    funeralDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    newFuneralDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CemetaryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeceasedId = table.Column<int>(type: "int", nullable: false),
                    category = table.Column<int>(type: "int", nullable: false),
                    VaultId = table.Column<int>(type: "int", nullable: true),
                    VenetianCarapace = table.Column<int>(type: "int", nullable: false),
                    TentWith6Chairs = table.Column<bool>(type: "bit", nullable: false),
                    ExtraChairs = table.Column<int>(type: "int", nullable: false),
                    RegisterStand = table.Column<bool>(type: "bit", nullable: false),
                    MilitarySetup = table.Column<bool>(type: "bit", nullable: false),
                    AwningOverCasket = table.Column<bool>(type: "bit", nullable: false),
                    FDRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_VaultOrder_Deceased_DeceasedId",
                        column: x => x.DeceasedId,
                        principalTable: "Deceased",
                        principalColumn: "DeceasedId",
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
                });

            migrationBuilder.CreateTable(
                name: "FuneralHomeContact",
                columns: table => new
                {
                    FuneralHomeContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuneralHomeId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowPrices = table.Column<bool>(type: "bit", nullable: false),
                    ContactRole = table.Column<int>(type: "int", nullable: false),
                    Interests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuneralHomeContact", x => x.FuneralHomeContactId);
                    table.ForeignKey(
                        name: "FK_FuneralHomeContact_FuneralHome_FuneralHomeId",
                        column: x => x.FuneralHomeId,
                        principalTable: "FuneralHome",
                        principalColumn: "FuneralHomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interaction",
                columns: table => new
                {
                    InteractionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nature = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FollowUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuneralHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interaction", x => x.InteractionId);
                    table.ForeignKey(
                        name: "FK_Interaction_FuneralHome_FuneralHomeId",
                        column: x => x.FuneralHomeId,
                        principalTable: "FuneralHome",
                        principalColumn: "FuneralHomeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FuneralHomeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photo_FuneralHome_FuneralHomeId",
                        column: x => x.FuneralHomeId,
                        principalTable: "FuneralHome",
                        principalColumn: "FuneralHomeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneType = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    FuneralHomeContactId = table.Column<int>(type: "int", nullable: true),
                    FuneralHomeId = table.Column<int>(type: "int", nullable: true),
                    PlantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phone_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_FuneralHome_FuneralHomeId",
                        column: x => x.FuneralHomeId,
                        principalTable: "FuneralHome",
                        principalColumn: "FuneralHomeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_FuneralHomeContact_FuneralHomeContactId",
                        column: x => x.FuneralHomeContactId,
                        principalTable: "FuneralHomeContact",
                        principalColumn: "FuneralHomeContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_Plant_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plant",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PlantId",
                table: "Employee",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_FuneralHome_PlantId",
                table: "FuneralHome",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_FuneralHomeContact_FuneralHomeId",
                table: "FuneralHomeContact",
                column: "FuneralHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interaction_FuneralHomeId",
                table: "Interaction",
                column: "FuneralHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_EmployeeId",
                table: "Phone",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_FuneralHomeContactId",
                table: "Phone",
                column: "FuneralHomeContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_FuneralHomeId",
                table: "Phone",
                column: "FuneralHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_PlantId",
                table: "Phone",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_FuneralHomeId",
                table: "Photo",
                column: "FuneralHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vault_AllowedToSelectId",
                table: "Vault",
                column: "AllowedToSelectId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_CemetaryId",
                table: "VaultOrder",
                column: "CemetaryId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_DeceasedId",
                table: "VaultOrder",
                column: "DeceasedId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_PlantId",
                table: "VaultOrder",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_VaultOrder_VaultId",
                table: "VaultOrder",
                column: "VaultId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interaction");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "VaultOrder");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "FuneralHomeContact");

            migrationBuilder.DropTable(
                name: "Cemetary");

            migrationBuilder.DropTable(
                name: "Deceased");

            migrationBuilder.DropTable(
                name: "Vault");

            migrationBuilder.DropTable(
                name: "FuneralHome");

            migrationBuilder.DropTable(
                name: "AllowedToSelect");

            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
