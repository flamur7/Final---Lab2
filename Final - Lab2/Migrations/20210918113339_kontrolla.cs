using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class kontrolla : Migration
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
                name: "KontrollaMjesoreId",
                table: "KontrollaMjeksores",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KontrollaMjeksores",
                table: "KontrollaMjeksores",
                column: "KontrollaMjesoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacients_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients",
                column: "KontrollaMjeksoreKontrollaMjesoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreKontrollaMjesoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors",
                column: "KontrollaMjeksoreKontrollaMjesoreId",
                principalTable: "KontrollaMjeksores",
                principalColumn: "KontrollaMjesoreId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Doctors_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_KontrollaMjeksores_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients");

            migrationBuilder.DropIndex(
                name: "IX_Pacients_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KontrollaMjeksores",
                table: "KontrollaMjeksores");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "KontrollaMjesoreId",
                table: "KontrollaMjeksores");

            migrationBuilder.DropColumn(
                name: "KontrollaMjeksoreKontrollaMjesoreId",
                table: "Doctors");

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
