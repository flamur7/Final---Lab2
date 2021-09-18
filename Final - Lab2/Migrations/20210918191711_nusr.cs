using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class nusr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nurses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnalizaId = table.Column<int>(type: "int", nullable: false),
                    Analizat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NrPersonal = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    OrariPuneId = table.Column<int>(type: "int", nullable: true),
                    OrariPushimit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesioni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_Analizats_AnalizaId",
                        column: x => x.AnalizaId,
                        principalTable: "Analizats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nurses_OrariPunes_OrariPuneId",
                        column: x => x.OrariPuneId,
                        principalTable: "OrariPunes",
                        principalColumn: "OrariPuneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_AnalizaId",
                table: "Nurses",
                column: "AnalizaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_OrariPuneId",
                table: "Nurses",
                column: "OrariPuneId");
        }
    }
}
