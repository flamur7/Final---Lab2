using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class _4555 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Pagesas_PagesaId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Fakturas_Faturimis_FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Fakturas_Pagesas_PagesaId",
                table: "Fakturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Analizats_AnalizaId",
                table: "Nurses");

            migrationBuilder.DropTable(
                name: "Faturimis");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Fakturas_FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropIndex(
                name: "IX_Fakturas_PagesaId",
                table: "Fakturas");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_PagesaId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "AnalizaId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropColumn(
                name: "PagesaId",
                table: "Analizats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnalizaId",
                table: "Nurses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FaturimiId",
                table: "Fakturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagesaId",
                table: "Analizats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Faturimis",
                columns: table => new
                {
                    FaturimiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kestet = table.Column<int>(type: "int", nullable: false),
                    KohaPageses = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturimis", x => x.FaturimiId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses",
                column: "AnalizaId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_PagesaId",
                table: "Analizats",
                column: "PagesaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Pagesas_PagesaId",
                table: "Analizats",
                column: "PagesaId",
                principalTable: "Pagesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Analizats_AnalizaId",
                table: "Nurses",
                column: "AnalizaId",
                principalTable: "Analizats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
