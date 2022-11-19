using System;
using Microsoft.EntityFrameworkCore;

public class ContextoBancoDeDados : DbContext {
  public DbSet<Jogo> Jogo { get; set; }
  public DbSet<Genero> Genero { get; set; }
  public DbSet<Sala> Sala { get; set; }
  public DbSet<Servidor> Servidor { get; set; }
  public DbSet<BancoDados> BancoDados { get; set; }
  public DbSet<Jogador> Jogador { get; set; }
  public DbSet<SalaJogador> SalaJogador { get; set; }
  public DbSet<Permissao> Permissao { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder configuracaoAcessoBanco) {
    configuracaoAcessoBanco.UseMySql(
      "Server=localhost;Database=monitoria_dotnet_webapi;Uid=root;Pwd=biel;",
      new MySqlServerVersion(new Version(8,0,31))
    );
  }

  protected override void OnModelCreating(ModelBuilder criacaoDaEntidade) {

    criacaoDaEntidade.Entity<Genero>(tabelaGenero => {

      string nomeTabela = this.GerarNomeTabela(new Genero().GetType().Name);

      tabelaGenero
        .ToTable(nomeTabela);

      tabelaGenero
        .HasKey(padrao => padrao.Id)
        .HasName("pk_" + nomeTabela);

      tabelaGenero.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaGenero.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaGenero.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaGenero.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaGenero.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);


      ////////////////////////////////////////////////////


      tabelaGenero.Property(genero => genero.Descricao)
        .HasMaxLength(40)
        .HasColumnName("descricao")
        .IsRequired();

    });


    criacaoDaEntidade.Entity<Permissao>(tabelaPermissao => {

      string nomeTabela = this.GerarNomeTabela(new Permissao().GetType().Name);

      tabelaPermissao
        .ToTable(nomeTabela);

      tabelaPermissao
        .HasKey(padrao => padrao.Id)
        .HasName("pk_" + nomeTabela);

      tabelaPermissao.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaPermissao.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaPermissao.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaPermissao.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaPermissao.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);


      ////////////////////////////////////////////////////


      tabelaPermissao.Property(permissao => permissao.Nivel)
        .HasMaxLength(30)
        .HasColumnName("nivel")
        .IsRequired();

    });

    criacaoDaEntidade.Entity<Jogo>(tabelaJogo => {

      string nomeTabela = this.GerarNomeTabela(new Jogo().GetType().Name);

      tabelaJogo
        .ToTable(nomeTabela);

      tabelaJogo
        .HasKey(padrao => padrao.Id)
        .HasName("PK_" + nomeTabela);

      tabelaJogo.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaJogo.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaJogo.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaJogo.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaJogo.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);

      //////////////////////////////////////////////////////////

      tabelaJogo.Property(jogo => jogo.Titulo)
        .HasMaxLength(40)
        .HasColumnName("titulo")
        .IsRequired();

      tabelaJogo.Property(jogo => jogo.Valor)
        .HasColumnType("DECIMAL(10,2)")
        .HasColumnName("valor")
        .IsRequired();
    
      tabelaJogo.Property(jogo => jogo.FaixaEtaria)
        .HasConversion<int>()
        .HasColumnName("faixa_etaria");

      tabelaJogo.HasOne(jogo => jogo.Genero);
      
      tabelaJogo.Property(jogo => jogo.GeneroId)
        .HasColumnName("genero_id");
    });


    criacaoDaEntidade.Entity<Sala>(tabelaSala => {

      string nomeTabela = this.GerarNomeTabela(new Sala().GetType().Name);

      tabelaSala
        .ToTable(nomeTabela);

      tabelaSala
        .HasKey(padrao => padrao.Id)
        .HasName("PK_" + nomeTabela);

      tabelaSala.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaSala.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaSala.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaSala.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaSala.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);

      //////////////////////////////////////////////////////////

      tabelaSala.Property(sala => sala.FechadaEm)
        .HasColumnType("DATETIME")
        .HasColumnName("fechada_em")
        .IsRequired();

      tabelaSala.HasOne(sala => sala.Servidor);
      tabelaSala.HasOne(sala => sala.Jogo);

      tabelaSala
        .HasMany(sala => sala.Jogadores)
        .WithMany(jogador => jogador.Salas)
        .UsingEntity<SalaJogador>();
      
      tabelaSala.Property(sala => sala.ServidorId)
        .HasColumnName("servidor_id");

      tabelaSala.Property(sala => sala.JogoId)
        .HasColumnName("jogo_id");
    });


    criacaoDaEntidade.Entity<Servidor>(tabelaServidor => {

      string nomeTabela = this.GerarNomeTabela(new Servidor().GetType().Name);

      tabelaServidor
        .ToTable(nomeTabela);

      tabelaServidor
        .HasKey(padrao => padrao.Id)
        .HasName("PK_" + nomeTabela);

      tabelaServidor.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaServidor.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaServidor.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaServidor.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaServidor.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);

      //////////////////////////////////////////////////////////

      tabelaServidor.Property(servidor => servidor.Nome)
        .HasMaxLength(30)
        .HasColumnName("nome")
        .IsRequired();

      tabelaServidor.Property(servidor => servidor.Regiao)
        .HasMaxLength(30)
        .HasConversion<string>()
        .HasColumnName("regiao")
        .IsRequired();

      tabelaServidor.Property(servidor => servidor.IpPublico)
        .HasMaxLength(15)
        .HasColumnName("ip_publico")
        .IsRequired();

      tabelaServidor.Property(servidor => servidor.IpPrivado)
        .HasMaxLength(15)
        .HasColumnName("ip_privado")
        .IsRequired();

      tabelaServidor.Property(servidor => servidor.SistemaOperacional)
        .HasMaxLength(30)
        .HasConversion<string>()
        .HasColumnName("sistema_operacional")
        .IsRequired();

      tabelaServidor.HasOne(servidor => servidor.BancoDados);

      tabelaServidor.Property(servidor => servidor.BancoDadosId)
        .HasColumnName("banco_dados_id");
    });


    criacaoDaEntidade.Entity<BancoDados>(tabelaBancoDados => {

      string nomeTabela = this.GerarNomeTabela(new BancoDados().GetType().Name);

      tabelaBancoDados
        .ToTable(nomeTabela);

      tabelaBancoDados
        .HasKey(padrao => padrao.Id)
        .HasName("PK_" + nomeTabela);

      tabelaBancoDados.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaBancoDados.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaBancoDados.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaBancoDados.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaBancoDados.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);

      //////////////////////////////////////////////////////////

      tabelaBancoDados.Property(bancoDados => bancoDados.Dialeto)
        .HasMaxLength(30)
        .HasConversion<string>()
        .HasColumnName("dialeto")
        .IsRequired();

      tabelaBancoDados.Property(bancoDados => bancoDados.Versao)
        .HasMaxLength(15)
        .HasColumnName("versao")
        .IsRequired();

      tabelaBancoDados.Property(bancoDados => bancoDados.Conexao)
        .HasMaxLength(512)
        .HasColumnName("conexao")
        .IsRequired();
    });


    criacaoDaEntidade.Entity<Jogador>(tabelaJogador => {

      string nomeTabela = this.GerarNomeTabela(new Jogador().GetType().Name);

      tabelaJogador
        .ToTable(nomeTabela);

      tabelaJogador
        .HasKey(padrao => padrao.Id)
        .HasName("PK_" + nomeTabela);

      tabelaJogador.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaJogador.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaJogador.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaJogador.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaJogador.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);

      //////////////////////////////////////////////////////////

      tabelaJogador.Property(jogador => jogador.Nome)
        .HasMaxLength(30)
        .HasColumnName("nome")
        .IsRequired();

      tabelaJogador.Property(jogador => jogador.Sobrenome)
        .HasMaxLength(30)
        .HasColumnName("sobrenome")
        .IsRequired();

      tabelaJogador.Property(jogador => jogador.Nascimento)
        .HasColumnType("DATETIME")
        .HasColumnName("nascimento")
        .IsRequired();

      tabelaJogador.Property(jogador => jogador.Email)
        .HasMaxLength(80)
        .HasColumnName("email")
        .IsRequired();

      tabelaJogador.Property(jogador => jogador.Usuario)
        .HasMaxLength(20)
        .HasColumnName("usuario")
        .IsRequired();

      tabelaJogador.Property(jogador => jogador.Senha)
        .HasMaxLength(512)
        .HasColumnName("senha")
        .IsRequired();

      tabelaJogador.Property(jogador => jogador.Moderador)
        .HasColumnName("moderador");

      tabelaJogador.Property(jogador => jogador.Gerente)
        .HasColumnName("gerente");

      tabelaJogador.Property(jogador => jogador.Suporte)
        .HasColumnName("suporte");

      tabelaJogador.Property(jogador => jogador.Desenvolvedor)
        .HasColumnName("desenvolvedor");


      tabelaJogador.HasOne(jogador => jogador.Permissao);
      tabelaJogador.Property(jogador => jogador.PermissaoId)
        .HasColumnName("permissao_id");

      tabelaJogador
        .HasMany(jogador => jogador.Salas)
        .WithMany(sala => sala.Jogadores)
        .UsingEntity<SalaJogador>();
    });


    criacaoDaEntidade.Entity<SalaJogador>(tabelaSalaJogador => {

      string nomeTabela = this.GerarNomeTabela(new SalaJogador().GetType().Name);

      tabelaSalaJogador
        .ToTable(nomeTabela);

      tabelaSalaJogador
        .HasKey(padrao => padrao.Id)
        .HasName("PK_" + nomeTabela);

      tabelaSalaJogador.Property(padrao => padrao.Id)
        .HasColumnName("id");

      tabelaSalaJogador.Property(padrao => padrao.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .HasDefaultValueSql("NOW()")
        .IsRequired();

      tabelaSalaJogador.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaSalaJogador.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .HasColumnType("VARCHAR(80)")
        .HasDefaultValueSql("'admin@master'")
        .IsRequired();

      tabelaSalaJogador.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por")
        .HasMaxLength(80);
        

      //////////////////////////////////////////////////////////

      tabelaSalaJogador.Property(salaJogador => salaJogador.SalaId)
        .HasColumnName("sala_id")
        .IsRequired();

      tabelaSalaJogador.Property(salaJogador => salaJogador.JogadorId)
        .HasColumnName("jogador_id")
        .IsRequired();
    });

  }

  public string GerarNomeTabela(string nomeClasse) {

    string prefixo = "tab_";

    if (nomeClasse.EndsWith("r") || nomeClasse.EndsWith("l")) return (prefixo + nomeClasse + "es").ToLower();
    if (nomeClasse.EndsWith("m")) return (prefixo + nomeClasse.Remove(nomeClasse.Length - 1) + "ns").ToLower();
    if (nomeClasse.EndsWith("ao")) return (prefixo + nomeClasse.Remove(nomeClasse.Length - 2) + "oes").ToLower();
    if (nomeClasse.EndsWith("s")) return (prefixo + nomeClasse).ToLower();

    return (prefixo + nomeClasse + "s").ToLower();
  }

}