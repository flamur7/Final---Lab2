using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class ki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_KontrollaMjeksores_KontrollaMjeksoreId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_KontrollaMjeksoreId",
                table: "Pacients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KontrollaMjeksores",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_KontrollaMjeksoreId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "KontrollaMjeksoreId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "KontrollaMjeksoreId",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "OrariPunes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KontrollaMjesoreId",
                table: "KontrollaMjeksores",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Analizats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "Analizats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KontrollaMjeksores",
                table: "KontrollaMjeksores",
                column: "KontrollaMjesoreId");

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    FeedBackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(nullable: true),
                    Field = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.FeedBackId);
                });

            migrationBuilder.CreateTable(
                name: "Technicals",
                columns: table => new
                {
                    TechnicalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(nullable: true),
                    Mbiemri = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Pervoja = table.Column<string>(nullable: true),
                    Shkollimi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicals", x => x.TechnicalId);
                });

            migrationBuilder.CreateTable(
                name: "Detajets",
                columns: table => new
                {
                    DetajetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedBackId = table.Column<int>(nullable: false),
                    Sherbimet = table.Column<string>(nullable: true),
                    Arsyja = table.Column<string>(nullable: true),
                    Vlersimi = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detajets", x => x.DetajetId);
                    table.ForeignKey(
                        name: "FK_Detajets_FeedBacks_FeedBackId",
                        column: x => x.FeedBackId,
                        principalTable: "FeedBacks",
                        principalColumn: "FeedBackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreKontrollaMjesoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrariPunes_TechnicalId",
                table: "OrariPunes",
                column: "TechnicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreKontrollaMjesoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_AppointmentId",
                table: "Analizats",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats",
                column: "TechnicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Detajets_FeedBackId",
                table: "Detajets",
                column: "FeedBackId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreKontrollaMjesoreId",
                principalTable: "KontrollaMjeksores",
                principalColumn: "KontrollaMjesoreId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrariPunes_Technicals_TechnicalId",
                table: "OrariPunes",
                column: "TechnicalId",
                principalTable: "Technicals",
                principalColumn: "TechnicalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreKontrollaMjesoreId",
                principalTable: "KontrollaMjeksores",
                principalColumn: "KontrollaMjesoreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Appointments_AppointmentId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Analizats_Technicals_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_OrariPunes_Technicals_TechnicalId",
                table: "OrariPunes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients");

            migrationBuilder.DropTable(
                name: "Detajets");

            migrationBuilder.DropTable(
                name: "Technicals");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_OrariPunes_TechnicalId",
                table: "OrariPunes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KontrollaMjeksores",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_AppointmentId",
                table: "Analizats");

            migrationBuilder.DropIndex(
                name: "IX_Analizats_TechnicalId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "TechnicalId",
                table: "OrariPunes");

            migrationBuilder.DropColumn(
                name: "KontrollaMjesoreId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Analizats");

            migrationBuilder.DropColumn(
                name: "TechnicalId",
                table: "Analizats");

            migrationBuilder.AddColumn<int>(
                name: "KontrollaMjeksoreId",
                table: "Pacients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KontrollaMjeksores",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KontrollaMjeksoreId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KontrollaMjeksores",
                table: "KontrollaMjeksores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_KontrollaMjeksoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_KontrollaMjeksoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreId",
                principalTable: "KontrollaMjeksores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_KontrollaMjeksores_KontrollaMjeksoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreId",
                principalTable: "KontrollaMjeksores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
