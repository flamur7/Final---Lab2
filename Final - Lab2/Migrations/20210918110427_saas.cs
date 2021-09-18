﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class saas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Analizats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_AppointmentId",
                table: "Analizats",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats",
                column: "TechnicalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Appointments_AppointmentId",
                table: "Analizats",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Analizats_Appointments_AppointmentId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_AppointmentId",
                table: "Analizats");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "TechnicalId",
                table: "Analizats");
        }
    }
}
