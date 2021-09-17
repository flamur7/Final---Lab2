using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturimis_Terapis_TerapiId",
                table: "Faturimis");

            migrationBuilder.DropColumn(
                name: "TerapiaId",
                table: "Faturimis");

            migrationBuilder.AlterColumn<int>(
                name: "TerapiId",
                table: "Faturimis",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Faturimis_Terapis_TerapiId",
                table: "Faturimis",
                column: "TerapiId",
                principalTable: "Terapis",
                principalColumn: "TerapiId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturimis_Terapis_TerapiId",
                table: "Faturimis");

            migrationBuilder.AlterColumn<int>(
                name: "TerapiId",
                table: "Faturimis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TerapiaId",
                table: "Faturimis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Faturimis_Terapis_TerapiId",
                table: "Faturimis",
                column: "TerapiId",
                principalTable: "Terapis",
                principalColumn: "TerapiId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
