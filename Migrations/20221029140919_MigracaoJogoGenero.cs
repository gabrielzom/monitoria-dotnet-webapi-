using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace monitoria_dotnet_webapi.Migrations
{
    public partial class MigracaoJogoGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_generos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<int>(type: "int", nullable: false),
                    atualizado_por = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tab_generos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_jogos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    titulo = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    faixa_etaria = table.Column<int>(type: "int", nullable: false),
                    genero_id = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<int>(type: "int", nullable: false),
                    atualizado_por = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_jogos", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_jogos_tab_generos_genero_id",
                        column: x => x.genero_id,
                        principalTable: "tab_generos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tab_jogos_genero_id",
                table: "tab_jogos",
                column: "genero_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tab_jogos");

            migrationBuilder.DropTable(
                name: "tab_generos");
        }
    }
}
