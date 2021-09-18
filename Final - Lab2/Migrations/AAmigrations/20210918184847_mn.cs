using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class mn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "TechnicalId",
                table: "Analizats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats",
                column: "TechnicalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats",
                column: "TechnicalId",
                principalTable: "Technicals",
                principalColumn: "TechnicalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
