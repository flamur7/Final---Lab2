using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class dfgf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fakturas_Faturimis_FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Fakturas_Pagesas_PagesaId",
                table: "Fakturas");

            migrationBuilder.DropIndex(
                name: "IX_Fakturas_FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropIndex(
                name: "IX_Fakturas_PagesaId",
                table: "Fakturas");

            migrationBuilder.DropColumn(
                name: "FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropColumn(
                name: "PagesaId",
                table: "Fakturas");

            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Pagesas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Faturimis",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagesas_FakturaId",
                table: "Pagesas",
                column: "FakturaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pagesas_Fakturas_FakturaId",
                table: "Pagesas",
                column: "FakturaId",
                principalTable: "Fakturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturimis_Fakturas_FakturaId",
                table: "Faturimis");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagesas_Fakturas_FakturaId",
                table: "Pagesas");

            migrationBuilder.DropIndex(
                name: "IX_Pagesas_FakturaId",
                table: "Pagesas");

            migrationBuilder.DropIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Pagesas");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Faturimis");

            migrationBuilder.AddColumn<int>(
                name: "FaturimiId",
                table: "Fakturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagesaId",
                table: "Fakturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fakturas_FaturimiId",
                table: "Fakturas",
                column: "FaturimiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fakturas_PagesaId",
                table: "Fakturas",
                column: "PagesaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fakturas_Faturimis_FaturimiId",
                table: "Fakturas",
                column: "FaturimiId",
                principalTable: "Faturimis",
                principalColumn: "FaturimiId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fakturas_Pagesas_PagesaId",
                table: "Fakturas",
                column: "PagesaId",
                principalTable: "Pagesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
