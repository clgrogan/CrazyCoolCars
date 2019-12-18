using Microsoft.EntityFrameworkCore.Migrations;

namespace CrazyCoolCars.Migrations
{
    public partial class CarsTableAddedYearMakeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Cars");
        }
    }
}
