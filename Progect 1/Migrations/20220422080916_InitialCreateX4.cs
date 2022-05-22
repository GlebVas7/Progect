using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Progect_1.Migrations
{
    public partial class InitialCreateX4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data_Of_Special_Offer",
                table: "Special_Offers",
                newName: "DataOfSpecialOffer");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "Persons",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Price_Of_Order",
                table: "Orders",
                newName: "PriceOfOrder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataOfSpecialOffer",
                table: "Special_Offers",
                newName: "Data_Of_Special_Offer");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Persons",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "PriceOfOrder",
                table: "Orders",
                newName: "Price_Of_Order");
        }
    }
}
