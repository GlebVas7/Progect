using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Progect_1.Migrations
{
    public partial class InitialCreatX1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IndredientForDrink",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IndredientForDrink",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
