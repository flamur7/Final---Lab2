using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orari",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "Orari",
                table: "Nurses");

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Technicals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Receptionists",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Receptionists",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrariPushimit",
                table: "Receptionists",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Nurses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrariPushimit",
                table: "Nurses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Doctors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Doctors",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Technicals_OrariId",
                table: "Technicals",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_AppointmentId",
                table: "Receptionists",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_OrariId",
                table: "Receptionists",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_OrariId",
                table: "Nurses",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentId",
                table: "Doctors",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OrariId",
                table: "Doctors",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PacientId",
                table: "Appointments",
                column: "PacientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Appointments_AppointmentId",
                table: "Doctors",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Oraris_OrariId",
                table: "Doctors",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Oraris_OrariId",
                table: "Nurses",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptionists_Appointments_AppointmentId",
                table: "Receptionists",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptionists_Oraris_OrariId",
                table: "Receptionists",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technicals_Oraris_OrariId",
                table: "Technicals",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Appointments_AppointmentId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Oraris_OrariId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Oraris_OrariId",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptionists_Appointments_AppointmentId",
                table: "Receptionists");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptionists_Oraris_OrariId",
                table: "Receptionists");

            migrationBuilder.DropForeignKey(
                name: "FK_Technicals_Oraris_OrariId",
                table: "Technicals");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Oraris");

            migrationBuilder.DropIndex(
                name: "IX_Technicals_OrariId",
                table: "Technicals");

            migrationBuilder.DropIndex(
                name: "IX_Receptionists_AppointmentId",
                table: "Receptionists");

            migrationBuilder.DropIndex(
                name: "IX_Receptionists_OrariId",
                table: "Receptionists");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_OrariId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AppointmentId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_OrariId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Technicals");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "OrariPushimit",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "OrariPushimit",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Doctors");

            migrationBuilder.AddColumn<string>(
                name: "Orari",
                table: "Receptionists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Orari",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
