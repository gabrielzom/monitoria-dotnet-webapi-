using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace monitoria_dotnet_webapi.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_bancodados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dialeto = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    versao = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conexao = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_bancodados", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_generos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tab_generos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_permissoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nivel = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tab_permissoes", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_servidores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    regiao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ip_publico = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ip_privado = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sistema_operacional = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    banco_dados_id = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_servidores", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_servidores_tab_bancodados_banco_dados_id",
                        column: x => x.banco_dados_id,
                        principalTable: "tab_bancodados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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

            migrationBuilder.CreateTable(
                name: "tab_jogadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sobrenome = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nascimento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    email = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usuario = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    moderador = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    gerente = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    suporte = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    desenvolvedor = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    permissao_id = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_jogadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_jogadores_tab_permissoes_permissao_id",
                        column: x => x.permissao_id,
                        principalTable: "tab_permissoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_salas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fechada_em = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    servidor_id = table.Column<int>(type: "int", nullable: false),
                    jogo_id = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_salas", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_salas_tab_jogos_jogo_id",
                        column: x => x.jogo_id,
                        principalTable: "tab_jogos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tab_salas_tab_servidores_servidor_id",
                        column: x => x.servidor_id,
                        principalTable: "tab_servidores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tab_salajogadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    sala_id = table.Column<int>(type: "int", nullable: false),
                    jogador_id = table.Column<int>(type: "int", nullable: false),
                    criado_em = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "NOW()"),
                    atualizado_em = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    criado_por = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualizado_por = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_salajogadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_tab_salajogadores_tab_jogadores_jogador_id",
                        column: x => x.jogador_id,
                        principalTable: "tab_jogadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tab_salajogadores_tab_salas_sala_id",
                        column: x => x.sala_id,
                        principalTable: "tab_salas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tab_jogadores_permissao_id",
                table: "tab_jogadores",
                column: "permissao_id");

            migrationBuilder.CreateIndex(
                name: "IX_tab_jogos_genero_id",
                table: "tab_jogos",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "IX_tab_salajogadores_jogador_id",
                table: "tab_salajogadores",
                column: "jogador_id");

            migrationBuilder.CreateIndex(
                name: "IX_tab_salajogadores_sala_id",
                table: "tab_salajogadores",
                column: "sala_id");

            migrationBuilder.CreateIndex(
                name: "IX_tab_salas_jogo_id",
                table: "tab_salas",
                column: "jogo_id");

            migrationBuilder.CreateIndex(
                name: "IX_tab_salas_servidor_id",
                table: "tab_salas",
                column: "servidor_id");

            migrationBuilder.CreateIndex(
                name: "IX_tab_servidores_banco_dados_id",
                table: "tab_servidores",
                column: "banco_dados_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tab_salajogadores");

            migrationBuilder.DropTable(
                name: "tab_jogadores");

            migrationBuilder.DropTable(
                name: "tab_salas");

            migrationBuilder.DropTable(
                name: "tab_permissoes");

            migrationBuilder.DropTable(
                name: "tab_jogos");

            migrationBuilder.DropTable(
                name: "tab_servidores");

            migrationBuilder.DropTable(
                name: "tab_generos");

            migrationBuilder.DropTable(
                name: "tab_bancodados");
        }
    }
}
