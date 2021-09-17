using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(nullable: true),
                    Mbiemri = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Profesioni = table.Column<string>(nullable: true),
                    Specalizimi = table.Column<string>(nullable: true),
                    Titulli = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

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
                    Valuta = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(nullable: true),
                    Mbiemri = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Profesioni = table.Column<string>(nullable: true),
                    Orari = table.Column<string>(nullable: true),
                    Analizat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    PhotoUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receptionists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(nullable: true),
                    Mbiemri = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Profesioni = table.Column<string>(nullable: true),
                    Orari = table.Column<string>(nullable: true),
                    NrTermineve = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptionists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technicals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(nullable: true),
                    Mbiemri = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Profesioni = table.Column<string>(nullable: true),
                    Shkollimi = table.Column<string>(nullable: true),
                    Pervoja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terapis",
                columns: table => new
                {
                    TerapiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacientiId = table.Column<int>(nullable: false),
                    Semundje = table.Column<string>(nullable: true),
                    Barnat = table.Column<string>(nullable: true),
                    Kohezgjatja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapis", x => x.TerapiId);
                    table.ForeignKey(
                        name: "FK_Terapis_Pacients_PacientiId",
                        column: x => x.PacientiId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faturimis",
                columns: table => new
                {
                    FaturimiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                name: "IX_Faturimis_TerapiId",
                table: "Faturimis",
                column: "TerapiId");

            migrationBuilder.CreateIndex(
                name: "IX_Terapis_PacientiId",
                table: "Terapis",
                column: "PacientiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Faturimis");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "Receptionists");

            migrationBuilder.DropTable(
                name: "Technicals");

            migrationBuilder.DropTable(
                name: "Fakturas");

            migrationBuilder.DropTable(
                name: "Terapis");

            migrationBuilder.DropTable(
                name: "Pacients");
        }
    }
}
