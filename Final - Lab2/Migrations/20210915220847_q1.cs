using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class q1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fakturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Shuma = table.Column<int>(nullable: false),
                    Valuta = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faturimis",
                columns: table => new
                {
                    FaturimiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacientiId = table.Column<int>(nullable: false),
                    FakturaId = table.Column<int>(nullable: false),
                    TerapiaId = table.Column<int>(nullable: false),
                    TerapiId = table.Column<int>(nullable: true),
                    KohaPageses = table.Column<string>(nullable: true),
                    Kestet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturimis", x => x.FaturimiId);
                    table.ForeignKey(
                        name: "FK_Faturimis_Fakturas_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Fakturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faturimis_Pacients_PacientiId",
                        column: x => x.PacientiId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faturimis_Terapis_TerapiId",
                        column: x => x.TerapiId,
                        principalTable: "Terapis",
                        principalColumn: "TerapiId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_PacientiId",
                table: "Faturimis",
                column: "PacientiId");

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_TerapiId",
                table: "Faturimis",
                column: "TerapiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faturimis");

            migrationBuilder.DropTable(
                name: "Fakturas");
        }
    }
}
