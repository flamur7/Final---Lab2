using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faturimis_Terapis_TerapiId",
                table: "Faturimis");

            migrationBuilder.DropIndex(
                name: "IX_Faturimis_TerapiId",
                table: "Faturimis");

            migrationBuilder.DropColumn(
                name: "TerapiId",
                table: "Faturimis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TerapiId",
                table: "Faturimis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Faturimis_TerapiId",
                table: "Faturimis",
                column: "TerapiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faturimis_Terapis_TerapiId",
                table: "Faturimis",
                column: "TerapiId",
                principalTable: "Terapis",
                principalColumn: "TerapiId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
