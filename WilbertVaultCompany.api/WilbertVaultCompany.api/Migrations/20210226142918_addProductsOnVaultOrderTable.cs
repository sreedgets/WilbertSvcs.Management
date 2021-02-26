using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addProductsOnVaultOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cemetary",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductsOnVaultOrder",
                columns: table => new
                {
                    ProductsOnVaultOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaultOrderId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ovation = table.Column<bool>(type: "bit", nullable: false),
                    Decoration = table.Column<bool>(type: "bit", nullable: false),
                    Legacy = table.Column<bool>(type: "bit", nullable: false),
                    VenetianCarapace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedToSelectId = table.Column<int>(type: "int", nullable: false),
                    UpChargeForLegacy = table.Column<bool>(type: "bit", nullable: false),
                    UpChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsOnVaultOrder", x => x.ProductsOnVaultOrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsOnVaultOrder");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cemetary",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
