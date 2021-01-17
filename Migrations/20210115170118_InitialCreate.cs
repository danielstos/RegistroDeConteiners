using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroDeConteiners.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteiner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cliente = table.Column<string>(type: "TEXT", nullable: true),
                    Numerodecntr = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteiner", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacoes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Navio = table.Column<string>(type: "TEXT", nullable: true),
                    TipodeMv = table.Column<string>(type: "TEXT", nullable: true),
                    DtInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DtFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConteinerID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacoes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movimentacoes_Conteiner_ConteinerID",
                        column: x => x.ConteinerID,
                        principalTable: "Conteiner",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacoes_ConteinerID",
                table: "Movimentacoes",
                column: "ConteinerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimentacoes");

            migrationBuilder.DropTable(
                name: "Conteiner");
        }
    }
}
