using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertFSvcs.api.Migrations
{
    public partial class addWilbertDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    PlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(nullable: true),
                    PlantManagerEmail = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    County = table.Column<string>(nullable: true),
                    PrintCompletedOrders = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantId = table.Column<int>(nullable: false),
                    CanDoFollowUps = table.Column<bool>(nullable: false),
                    Title = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    County = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    PhotoImage = table.Column<byte[]>(nullable: true)
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
                    FuneralHomeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentFuneralHomeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PlantId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    County = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true)
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
                name: "FuneralHomeContact",
                columns: table => new
                {
                    FuneralHomeContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuneralHomeId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Spouse = table.Column<string>(nullable: true),
                    ShowPrices = table.Column<bool>(nullable: false),
                    ContactRole = table.Column<int>(nullable: false),
                    Interests = table.Column<string>(nullable: true),
                    Photos = table.Column<byte[]>(nullable: true)
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
                    InteractionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Nature = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    FollowUpDate = table.Column<DateTime>(nullable: false),
                    Reason = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    Outcome = table.Column<string>(nullable: true),
                    FuneralHomeId = table.Column<int>(nullable: true)
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
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoName = table.Column<string>(nullable: true),
                    PhotoImage = table.Column<byte[]>(nullable: true),
                    FuneralHomeId = table.Column<int>(nullable: true)
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
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityId = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    PhoneType = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true),
                    FuneralHomeContactId = table.Column<int>(nullable: true),
                    FuneralHomeId = table.Column<int>(nullable: true),
                    PlantId = table.Column<int>(nullable: true)
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
                        name: "FK_Phone_FuneralHomeContact_FuneralHomeContactId",
                        column: x => x.FuneralHomeContactId,
                        principalTable: "FuneralHomeContact",
                        principalColumn: "FuneralHomeContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phone_FuneralHome_FuneralHomeId",
                        column: x => x.FuneralHomeId,
                        principalTable: "FuneralHome",
                        principalColumn: "FuneralHomeId",
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
                name: "Employee");

            migrationBuilder.DropTable(
                name: "FuneralHomeContact");

            migrationBuilder.DropTable(
                name: "FuneralHome");

            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
