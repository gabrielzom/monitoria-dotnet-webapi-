using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace monitoria_dotnet_webapi.Migrations
{
    public partial class PrimeiraMigracaoCriadoPor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_servidores",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_servidores",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_salas",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_salas",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_salajogadores",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_salajogadores",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_permissoes",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_permissoes",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_jogos",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_jogos",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_jogadores",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_jogadores",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_generos",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_generos",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_bancodados",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_bancodados",
                type: "varchar(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_servidores",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_servidores",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_salas",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_salas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_salajogadores",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_salajogadores",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_permissoes",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_permissoes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_jogos",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_jogos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_jogadores",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_jogadores",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_generos",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_generos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "criado_por",
                table: "tab_bancodados",
                type: "longtext",
                nullable: false,
                defaultValueSql: "'admin@master'",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldDefaultValueSql: "'admin@master'")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "atualizado_por",
                table: "tab_bancodados",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
