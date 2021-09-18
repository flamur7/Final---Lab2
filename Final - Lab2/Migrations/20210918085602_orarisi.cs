using Microsoft.EntityFrameworkCore.Migrations;

namespace Final___Lab2.Migrations
{
    public partial class orarisi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Oraris_OrariId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Oraris_OrariId",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptionists_Oraris_OrariId",
                table: "Receptionists");

            migrationBuilder.DropForeignKey(
                name: "FK_Technicals_Oraris_OrariId",
                table: "Technicals");

            migrationBuilder.DropTable(
                name: "Oraris");

            migrationBuilder.DropIndex(
                name: "IX_Technicals_OrariId",
                table: "Technicals");

            migrationBuilder.DropIndex(
                name: "IX_Receptionists_OrariId",
                table: "Receptionists");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_OrariId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_OrariId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Technicals");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "OrariId",
                table: "Doctors");

            migrationBuilder.AddColumn<int>(
                name: "OrariPuneId",
                table: "Technicals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariPuneId",
                table: "Receptionists",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariPuneId",
                table: "Nurses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrariPunes",
                columns: table => new
                {
                    OrariPuneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dita = table.Column<string>(nullable: true),
                    Koha = table.Column<string>(nullable: true),
                    Java = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrariPunes", x => x.OrariPuneId);
                    table.ForeignKey(
                        name: "FK_OrariPunes_Doctors_Id",
                        column: x => x.Id,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Technicals_OrariPuneId",
                table: "Technicals",
                column: "OrariPuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_OrariPuneId",
                table: "Receptionists",
                column: "OrariPuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_OrariPuneId",
                table: "Nurses",
                column: "OrariPuneId");

            migrationBuilder.CreateIndex(
                name: "IX_OrariPunes_Id",
                table: "OrariPunes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_OrariPunes_OrariPuneId",
                table: "Nurses",
                column: "OrariPuneId",
                principalTable: "OrariPunes",
                principalColumn: "OrariPuneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptionists_OrariPunes_OrariPuneId",
                table: "Receptionists",
                column: "OrariPuneId",
                principalTable: "OrariPunes",
                principalColumn: "OrariPuneId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technicals_OrariPunes_OrariPuneId",
                table: "Technicals",
                column: "OrariPuneId",
                principalTable: "OrariPunes",
                principalColumn: "OrariPuneId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_OrariPunes_OrariPuneId",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Receptionists_OrariPunes_OrariPuneId",
                table: "Receptionists");

            migrationBuilder.DropForeignKey(
                name: "FK_Technicals_OrariPunes_OrariPuneId",
                table: "Technicals");

            migrationBuilder.DropTable(
                name: "OrariPunes");

            migrationBuilder.DropIndex(
                name: "IX_Technicals_OrariPuneId",
                table: "Technicals");

            migrationBuilder.DropIndex(
                name: "IX_Receptionists_OrariPuneId",
                table: "Receptionists");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_OrariPuneId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "OrariPuneId",
                table: "Technicals");

            migrationBuilder.DropColumn(
                name: "OrariPuneId",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "OrariPuneId",
                table: "Nurses");

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Technicals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Receptionists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Nurses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrariId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Oraris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paradite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pasdite = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oraris", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Technicals_OrariId",
                table: "Technicals",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionists_OrariId",
                table: "Receptionists",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_OrariId",
                table: "Nurses",
                column: "OrariId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OrariId",
                table: "Doctors",
                column: "OrariId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Oraris_OrariId",
                table: "Doctors",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Oraris_OrariId",
                table: "Nurses",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Receptionists_Oraris_OrariId",
                table: "Receptionists",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technicals_Oraris_OrariId",
                table: "Technicals",
                column: "OrariId",
                principalTable: "Oraris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
