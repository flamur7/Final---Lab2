using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class lp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Doctors_DoctorId",
                table: "Analizats");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_DoctorId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "KategoriaAnalizaveId",
                table: "Analizats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "KategoriaAnalizaves",
                columns: table => new
                {
                    KategoriaAnalizaveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lloji = table.Column<string>(nullable: true),
                    Rendesia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriaAnalizaves", x => x.KategoriaAnalizaveId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_KategoriaAnalizaveId",
                table: "Analizats",
                column: "KategoriaAnalizaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analizats_KategoriaAnalizaves_KategoriaAnalizaveId",
                table: "Analizats",
                column: "KategoriaAnalizaveId",
                principalTable: "KategoriaAnalizaves",
                principalColumn: "KategoriaAnalizaveId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_KategoriaAnalizaves_KategoriaAnalizaveId",
                table: "Analizats");

            migrationBuilder.DropTable(
                name: "KategoriaAnalizaves");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_KategoriaAnalizaveId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "KategoriaAnalizaveId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Analizats",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
