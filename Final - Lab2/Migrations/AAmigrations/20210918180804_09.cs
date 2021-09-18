using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class _09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_KategoritAnalizaves_KategoritAnalizaveId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_KontrollaMjeksores_Pagesas_PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropTable(
                name: "KategoritAnalizaves");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_KontrollaMjeksores_PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_KategoritAnalizaveId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "PagesaId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "KategoritAnalizaveId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "KontrollaMjeksores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Analizats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses",
                column: "AnalizaId");

            migrationBuilder.CreateIndex(
                name: "IX_KontrollaMjeksores_DoctorId",
                table: "KontrollaMjeksores",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_DoctorId",
                table: "Analizats",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_Doctors_DoctorId",
                table: "Analizats",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Analizats_Doctors_DoctorId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_KontrollaMjeksores_Doctors_DoctorId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_KontrollaMjeksores_DoctorId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_DoctorId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "PagesaId",
                table: "KontrollaMjeksores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategoritAnalizaveId",
                table: "Analizats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KategoritAnalizaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoritAnalizaves", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses",
                column: "AnalizaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KontrollaMjeksores_PagesaId",
                table: "KontrollaMjeksores",
                column: "PagesaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_KategoritAnalizaveId",
                table: "Analizats",
                column: "KategoritAnalizaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_KategoritAnalizaves_KategoritAnalizaveId",
                table: "Analizats",
                column: "KategoritAnalizaveId",
                principalTable: "KategoritAnalizaves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
