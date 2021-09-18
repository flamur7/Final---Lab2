using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class j : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Faturimis_Fakturas_FakturaId",
                table: "Faturimis");

            migrationBuilder.DropForeignKey(
                name: "FK_OrariPunes_Doctors_Id",
                table: "OrariPunes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Appointments_AppointmentId",
                table: "Pacients");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagesas_Fakturas_FakturaId",
                table: "Pagesas");

            migrationBuilder.DropTable(
                name: "Technicals");

            migrationBuilder.DropIndex(
                name: "IX_Pagesas_FakturaId",
                table: "Pagesas");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_AppointmentId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_OrariPunes_Id",
                table: "OrariPunes");

            migrationBuilder.DropIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Pagesas");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrariPunes");

            migrationBuilder.DropColumn(
                name: "FakturaId",
                table: "Faturimis");

            migrationBuilder.DropColumn(
                name: "TechnicalId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "FaturimiId",
                table: "Fakturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagesaId",
                table: "Fakturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacientId",
                table: "Appointments",
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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PacientId",
                table: "Appointments",
                column: "PacientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Pacients_PacientId",
                table: "Appointments",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Pacients_PacientId",
                table: "Appointments");

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

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PacientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "FaturimiId",
                table: "Fakturas");

            migrationBuilder.DropColumn(
                name: "PagesaId",
                table: "Fakturas");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Pagesas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Pacients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrariPunes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FakturaId",
                table: "Faturimis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Technicals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrPersonal = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    OrariPuneId = table.Column<int>(type: "int", nullable: true),
                    Pervoja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesioni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shkollimi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technicals_OrariPunes_OrariPuneId",
                        column: x => x.OrariPuneId,
                        principalTable: "OrariPunes",
                        principalColumn: "OrariPuneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagesas_FakturaId",
                table: "Pagesas",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_AppointmentId",
                table: "Pacients",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrariPunes_Id",
                table: "OrariPunes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_FakturaId",
                table: "Faturimis",
                column: "FakturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats",
                column: "TechnicalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Technicals_OrariPuneId",
                table: "Technicals",
                column: "OrariPuneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats",
                column: "TechnicalId",
                principalTable: "Technicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faturimis_Fakturas_FakturaId",
                table: "Faturimis",
                column: "FakturaId",
                principalTable: "Fakturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrariPunes_Doctors_Id",
                table: "OrariPunes",
                column: "Id",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Appointments_AppointmentId",
                table: "Pacients",
                column: "AppointmentId",
                principalTable: "Appointments",
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
    }
}
