using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class removedoctr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_Id",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_Id",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Appointments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    KontrollaMjeksoreKontrollaMjesoreId = table.Column<int>(type: "int", nullable: true),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrPersonal = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Profesioni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specalizimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulli = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                        column: x => x.KontrollaMjeksoreKontrollaMjesoreId,
                        principalTable: "KontrollaMjeksores",
                        principalColumn: "KontrollaMjesoreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_Id",
                table: "Appointments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreKontrollaMjesoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_Id",
                table: "Appointments",
                column: "Id",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
