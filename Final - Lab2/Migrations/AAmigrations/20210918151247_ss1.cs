using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class ss1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Appointments_AppointmentId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Appointments_AppointmentId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptionists_Appointments_AppointmentId",
                table: "Receptionists");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Receptionists_AppointmentId",
                table: "Receptionists");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AppointmentId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_AppointmentId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Receptionists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Analizats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacientId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_AppointmentId",
                table: "Receptionists",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AppointmentId",
                table: "Doctors",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_AppointmentId",
                table: "Analizats",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PacientId",
                table: "Appointments",
                column: "PacientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Appointments_AppointmentId",
                table: "Analizats",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Appointments_AppointmentId",
                table: "Doctors",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptionists_Appointments_AppointmentId",
                table: "Receptionists",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
