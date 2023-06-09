using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesFootball.Migrations
{
    public partial class BestPlayerShirtNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BestPlayerShirtNumber",
                table: "Football",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CoachCountry",
                table: "Football",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestPlayerShirtNumber",
                table: "Football");

            migrationBuilder.DropColumn(
                name: "CoachCountry",
                table: "Football");
        }
    }
}
