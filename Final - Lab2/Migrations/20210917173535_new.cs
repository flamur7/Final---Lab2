using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturimis_Fakturas_FakturaId",
                table: "Faturimis");

            migrationBuilder.DropIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Faturimis");

            migrationBuilder.AddColumn<int>(
                name: "FaturimiId",
                table: "Fakturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fakturas_FaturimiId",
                table: "Fakturas",
                column: "FaturimiId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fakturas_Faturimis_FaturimiId",
                table: "Fakturas",
                column: "FaturimiId",
                principalTable: "Faturimis",
                principalColumn: "FaturimiId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fakturas_Faturimis_FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropIndex(
                name: "IX_Fakturas_FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropColumn(
                name: "FaturimiId",
                table: "Fakturas");

            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Faturimis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis",
                column: "FakturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faturimis_Fakturas_FakturaId",
                table: "Faturimis",
                column: "FakturaId",
                principalTable: "Fakturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
