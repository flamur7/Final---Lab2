using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats",
                column: "TechnicalId",
                principalTable: "Technicals",
                principalColumn: "TechnicalId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
