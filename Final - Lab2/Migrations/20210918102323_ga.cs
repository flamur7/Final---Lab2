using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class ga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TechnicalId",
                table: "OrariPunes",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_OrariPunes_TechnicalId",
                table: "OrariPunes",
                column: "TechnicalId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrariPunes_Technicals_TechnicalId",
                table: "OrariPunes",
                column: "TechnicalId",
                principalTable: "Technicals",
                principalColumn: "TechnicalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrariPunes_Technicals_TechnicalId",
                table: "OrariPunes");

            migrationBuilder.DropTable(
                name: "Technicals");

            migrationBuilder.DropIndex(
                name: "IX_OrariPunes_TechnicalId",
                table: "OrariPunes");

            migrationBuilder.DropColumn(
                name: "TechnicalId",
                table: "OrariPunes");
        }
    }
}
