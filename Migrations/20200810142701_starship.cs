using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SakilaProject1.Migrations
{
    public partial class starship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Payment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_id = table.Column<int>(nullable: false),
                    Staff_id = table.Column<byte>(nullable: false),
                    Rental_id = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Payment_date = table.Column<DateTime>(nullable: false),
                    Last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Payment_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
