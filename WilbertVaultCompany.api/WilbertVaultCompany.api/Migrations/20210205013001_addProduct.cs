using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class addProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ovation = table.Column<bool>(type: "bit", nullable: false),
                    Decoration = table.Column<bool>(type: "bit", nullable: false),
                    Legacy = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowedToSelectId = table.Column<int>(type: "int", nullable: false),
                    UpChargeForLegacy = table.Column<bool>(type: "bit", nullable: false),
                    UpChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    Color1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
