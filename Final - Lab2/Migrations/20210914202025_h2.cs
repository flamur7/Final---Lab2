using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class h2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barnat",
                table: "Terapis",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kohezgjatja",
                table: "Terapis",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Semundje",
                table: "Terapis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barnat",
                table: "Terapis");

            migrationBuilder.DropColumn(
                name: "Kohezgjatja",
                table: "Terapis");

            migrationBuilder.DropColumn(
                name: "Semundje",
                table: "Terapis");
        }
    }
}
