using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Progect_1.Migrations
{
    public partial class x26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceOfOrder",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PriceOfOrder",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
