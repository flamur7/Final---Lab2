using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class sxsxss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Pacients_PacientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PacientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Pacients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_AppointmentId",
                table: "Pacients",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Appointments_AppointmentId",
                table: "Pacients",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Appointments_AppointmentId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_AppointmentId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Pacients");

            migrationBuilder.AddColumn<int>(
                name: "PacientId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
