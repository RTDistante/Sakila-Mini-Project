using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SakilaProject1.Migrations
{
    public partial class immortal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "Payment",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Inventory_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Film_id = table.Column<int>(nullable: false),
                    Store_id = table.Column<int>(nullable: false),
                    Last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Inventory_id);
                });

            migrationBuilder.CreateTable(
                name: "Rental",
                columns: table => new
                {
                    Rental_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rental_date = table.Column<DateTime>(nullable: false),
                    Inventory_id = table.Column<int>(nullable: false),
                    Customer_id = table.Column<int>(nullable: false),
                    Return_date = table.Column<DateTime>(nullable: true),
                    Staff_id = table.Column<byte>(nullable: false),
                    Last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rental", x => x.Rental_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Rental");

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
