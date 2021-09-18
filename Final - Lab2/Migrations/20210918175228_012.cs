using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class _012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KontrollaMjeksores_Pagesas_PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_KontrollaMjeksores_PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "KontrollaMjeksores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KontrollaMjeksores_DoctorId",
                table: "KontrollaMjeksores",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_KontrollaMjeksores_Doctors_DoctorId",
                table: "KontrollaMjeksores",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KontrollaMjeksores_Doctors_DoctorId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_KontrollaMjeksores_DoctorId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "KontrollaMjeksores");

            migrationBuilder.AddColumn<int>(
                name: "PagesaId",
                table: "KontrollaMjeksores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KontrollaMjeksores_PagesaId",
                table: "KontrollaMjeksores",
                column: "PagesaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KontrollaMjeksores_Pagesas_PagesaId",
                table: "KontrollaMjeksores",
                column: "PagesaId",
                principalTable: "Pagesas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
