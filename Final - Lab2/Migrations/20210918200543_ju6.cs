using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class ju6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrPersonal = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(nullable: true),
                    Mbiemri = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Profesioni = table.Column<string>(nullable: true),
                    OrariPushimit = table.Column<string>(nullable: true),
                    Analizat = table.Column<string>(nullable: true),
                    OrariPuneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_OrariPunes_OrariPuneId",
                        column: x => x.OrariPuneId,
                        principalTable: "OrariPunes",
                        principalColumn: "OrariPuneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_OrariPuneId",
                table: "Nurses",
                column: "OrariPuneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nurses");
        }
    }
}
