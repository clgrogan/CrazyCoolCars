using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrazyCoolCars.Migrations
{
    public partial class MostEndpointsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Cars");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatePurchased",
                table: "Cars",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePurchased",
                table: "Cars");

            migrationBuilder.AddColumn<DateTime>(
                name: "MyProperty",
                table: "Cars",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
