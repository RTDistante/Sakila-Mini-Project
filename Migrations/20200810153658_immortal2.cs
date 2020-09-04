using Microsoft.EntityFrameworkCore.Migrations;

namespace SakilaProject1.Migrations
{
    public partial class immortal2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payment",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

       
    }
}
