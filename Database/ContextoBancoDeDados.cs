using System;
using Microsoft.EntityFrameworkCore;

public class ContextoBancoDeDados : DbContext {
  public DbSet<Jogo> Jogo { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder configuracaoAcessoBanco) {
    configuracaoAcessoBanco.UseMySql(
      "Server=localhost;Database=monitoria_dotnet_webapi;Uid=root;Pwd=biel;",
      new MySqlServerVersion(new Version(8,0,31))
    );
  }

  protected override void OnModelCreating(ModelBuilder criacaoDaEntidade) {
    criacaoDaEntidade.Entity<Jogo>(tabelaJogo => {

      tabelaJogo.ToTable("jogo");
      tabelaJogo.HasKey(jogo => jogo.Id).HasName("id");

      tabelaJogo.Property(jogo => jogo.Nome)
        .HasMaxLength(40)
        .HasColumnName("nome")
        .IsRequired();

      tabelaJogo.Property(jogo => jogo.Valor)
        .HasColumnType("DECIMAL(10,2)")
        .HasColumnName("valor")
        .IsRequired();
      
      tabelaJogo.Property(jogo => jogo.CriadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("criado_em")
        .IsRequired();

      tabelaJogo.Property(jogo => jogo.AtualizadoEm)
        .HasColumnType("DATETIME")
        .HasColumnName("atualizado_em");

      tabelaJogo.Property(jogo => jogo.CriadoPor)
        .HasColumnName("criado_por")
        .IsRequired();

      tabelaJogo.Property(jogo => jogo.AtualizadoPor)
        .HasColumnName("atualizado_por");
        
    });
  }
}