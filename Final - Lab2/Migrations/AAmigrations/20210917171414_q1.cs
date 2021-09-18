using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class q1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KategoritAnalizaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoritAnalizaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oraris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paradite = table.Column<string>(nullable: true),
                    Pasdite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oraris", x => x.Id);
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
                    Pervoja = table.Column<string>(nullable: true),
                    OrariId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technicals_Oraris_OrariId",
                        column: x => x.OrariId,
                        principalTable: "Oraris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    OrariPushimit = table.Column<string>(nullable: true),
                    Analizat = table.Column<string>(nullable: true),
                    OrariId = table.Column<int>(nullable: true),
                    AnalizaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_Oraris_OrariId",
                        column: x => x.OrariId,
                        principalTable: "Oraris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    PhotoUrl = table.Column<string>(nullable: true),
                    KontrollaMjeksoreId = table.Column<int>(nullable: true),
                    AnalizatId = table.Column<int>(nullable: true),
                    PagesaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    PacientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Pacients_PacientId",
                        column: x => x.PacientId,
                        principalTable: "Pacients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    AppointmentId = table.Column<int>(nullable: true),
                    OrariPushimit = table.Column<string>(nullable: true),
                    NrTermineve = table.Column<int>(nullable: false),
                    OrariId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptionists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receptionists_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receptionists_Oraris_OrariId",
                        column: x => x.OrariId,
                        principalTable: "Oraris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagesas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardHolder = table.Column<string>(nullable: true),
                    CardNumber = table.Column<long>(nullable: false),
                    Confirmation = table.Column<bool>(nullable: false),
                    ReceptionistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagesas_Receptionists_ReceptionistId",
                        column: x => x.ReceptionistId,
                        principalTable: "Receptionists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Analizats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(nullable: true),
                    Pershkerimi = table.Column<string>(nullable: true),
                    TechnicalId = table.Column<int>(nullable: false),
                    KategoritAnalizaveId = table.Column<int>(nullable: true),
                    PagesaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analizats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analizats_KategoritAnalizaves_KategoritAnalizaveId",
                        column: x => x.KategoritAnalizaveId,
                        principalTable: "KategoritAnalizaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analizats_Pagesas_PagesaId",
                        column: x => x.PagesaId,
                        principalTable: "Pagesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analizats_Technicals_TechnicalId",
                        column: x => x.TechnicalId,
                        principalTable: "Technicals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Completed = table.Column<bool>(nullable: false),
                    PagesaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fakturas_Pagesas_PagesaId",
                        column: x => x.PagesaId,
                        principalTable: "Pagesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KontrollaMjeksores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pershkrimi = table.Column<string>(nullable: true),
                    TerapiId = table.Column<int>(nullable: true),
                    PagesaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KontrollaMjeksores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KontrollaMjeksores_Pagesas_PagesaId",
                        column: x => x.PagesaId,
                        principalTable: "Pagesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KontrollaMjeksores_Terapis_TerapiId",
                        column: x => x.TerapiId,
                        principalTable: "Terapis",
                        principalColumn: "TerapiId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faturimis",
                columns: table => new
                {
                    FaturimiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FakturaId = table.Column<int>(nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                });

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
                    AppointmentId = table.Column<int>(nullable: true),
                    KontrollaMjeksoreId = table.Column<int>(nullable: true),
                    OrariId = table.Column<int>(nullable: true),
                    Specalizimi = table.Column<string>(nullable: true),
                    Titulli = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreId",
                        column: x => x.KontrollaMjeksoreId,
                        principalTable: "KontrollaMjeksores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Oraris_OrariId",
                        column: x => x.OrariId,
                        principalTable: "Oraris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_KategoritAnalizaveId",
                table: "Analizats",
                column: "KategoritAnalizaveId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_PagesaId",
                table: "Analizats",
                column: "PagesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats",
                column: "TechnicalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PacientId",
                table: "Appointments",
                column: "PacientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentId",
                table: "Doctors",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_KontrollaMjeksoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OrariId",
                table: "Doctors",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Fakturas_PagesaId",
                table: "Fakturas",
                column: "PagesaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_KontrollaMjeksores_PagesaId",
                table: "KontrollaMjeksores",
                column: "PagesaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KontrollaMjeksores_TerapiId",
                table: "KontrollaMjeksores",
                column: "TerapiId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses",
                column: "AnalizaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_OrariId",
                table: "Nurses",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_AnalizatId",
                table: "Pacients",
                column: "AnalizatId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_KontrollaMjeksoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_PagesaId",
                table: "Pacients",
                column: "PagesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagesas_ReceptionistId",
                table: "Pagesas",
                column: "ReceptionistId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_AppointmentId",
                table: "Receptionists",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_OrariId",
                table: "Receptionists",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Technicals_OrariId",
                table: "Technicals",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Terapis_PacientiId",
                table: "Terapis",
                column: "PacientiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Analizats_AnalizaId",
                table: "Nurses",
                column: "AnalizaId",
                principalTable: "Analizats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Pagesas_PagesaId",
                table: "Pacients",
                column: "PagesaId",
                principalTable: "Pagesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_KontrollaMjeksores_KontrollaMjeksoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreId",
                principalTable: "KontrollaMjeksores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Analizats_AnalizatId",
                table: "Pacients",
                column: "AnalizatId",
                principalTable: "Analizats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_KategoritAnalizaves_KategoritAnalizaveId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Pagesas_PagesaId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_KontrollaMjeksores_Pagesas_PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Pagesas_PagesaId",
                table: "Pacients");

            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Terapis_Pacients_PacientiId",
                table: "Terapis");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Faturimis");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "Fakturas");

            migrationBuilder.DropTable(
                name: "KategoritAnalizaves");

            migrationBuilder.DropTable(
                name: "Pagesas");

            migrationBuilder.DropTable(
                name: "Receptionists");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Technicals");

            migrationBuilder.DropTable(
                name: "Oraris");

            migrationBuilder.DropTable(
                name: "Pacients");

            migrationBuilder.DropTable(
                name: "Analizats");

            migrationBuilder.DropTable(
                name: "KontrollaMjeksores");

            migrationBuilder.DropTable(
                name: "Terapis");
        }
    }
}
