using System;
using Microsoft.EntityFrameworkCore;

public class ContextoBancoDeDados : DbContext {
  public DbSet<Jogo> Jogo { get; set; }
  public DbSet<Genero> Genero { get; set; }


  protected override void OnConfiguring(DbContextOptionsBuilder configuracaoAcessoBanco) {
    configuracaoAcessoBanco.UseMySql(
      "Server=localhost;Database=monitoria_dotnet_webapi;Uid=root;Pwd=biel;",
      new MySqlServerVersion(new Version(8,0,31))
    );
  }

  protected override void OnModelCreating(ModelBuilder criacaoDaEntidade) {

    criacaoDaEntidade.Entity<Genero>(tabelaGenero => {

      string nomeTabela = "tab_" + new Genero().GetType().Name.ToLower() + "s";

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
        .IsRequired();

      tabelaGenero.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaGenero.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .IsRequired();

      tabelaGenero.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por");


      ////////////////////////////////////////////////////


      tabelaGenero.Property(genero => genero.Descricao)
        .HasMaxLength(40)
        .HasColumnName("descricao")
        .IsRequired();

    });

    criacaoDaEntidade.Entity<Jogo>(tabelaJogo => {

      string nomeTabela = "tab_" + new Jogo().GetType().Name.ToLower() + "s";

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
        .IsRequired();

      tabelaJogo.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaJogo.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .IsRequired();

      tabelaJogo.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por");

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

      string nomeTabela = "tab_" + new Sala().GetType().Name.ToLower() + "s";

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
        .IsRequired();

      tabelaSala.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaSala.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .IsRequired();

      tabelaSala.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por");

      //////////////////////////////////////////////////////////

      tabelaSala.Property(sala => sala.FechadaEm)
        .HasColumnType("DATETIME")
        .HasColumnName("fechada_em")
        .IsRequired();

      tabelaSala.HasOne(sala => sala.Servidor);
      tabelaSala.HasOne(sala => sala.Jogo);

      tabelaSala
        .HasMany(sala => sala.Pessoas)
        .WithMany(pessoa => pessoa.Salas);
      
      tabelaSala.Property(sala => sala.ServidorId)
        .HasColumnName("servidor_id");

      tabelaSala.Property(sala => sala.JogoId)
        .HasColumnName("jogo_id");
    });


    criacaoDaEntidade.Entity<Servidor>(tabelaServidor => {

      string nomeTabela = "tab_" + new Servidor().GetType().Name.ToLower() + "s";

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
        .IsRequired();

      tabelaServidor.Property(padrao => padrao.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaServidor.Property(padrao => padrao.CriadoPor)
        .HasColumnName("criado_por")
        .IsRequired();

      tabelaServidor.Property(padrao => padrao.AtualizadoPor)
        .HasColumnName("atualizado_por");

      //////////////////////////////////////////////////////////

      tabelaSala.Property(sala => sala.FechadaEm)
        .HasColumnType("DATETIME")
        .HasColumnName("fechada_em")
        .IsRequired();

      tabelaSala.HasOne(sala => sala.Servidor);
      tabelaSala.HasOne(sala => sala.Jogo);

      tabelaSala
        .HasMany(sala => sala.Pessoas)
        .WithMany(pessoa => pessoa.Salas);
      
      tabelaSala.Property(sala => sala.ServidorId)
        .HasColumnName("servidor_id");

      tabelaSala.Property(sala => sala.JogoId)
        .HasColumnName("jogo_id");
    });
  }

}