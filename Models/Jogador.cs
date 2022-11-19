public class Jogador : CamposPadroes {
  public string Nome { get; set; }
  public string Sobrenome { get; set; }
  public DateTime Nascimento { get; set; }
  public string Email { get; set; }
  public string Usuario { get; set; }
  public string Senha { get; set; }
  public bool? Moderador { get; set; } = null;
  public bool? Gerente { get; set; } = null;
  public bool? Suporte { get; set; } = null; 
  public bool? Desenvolvedor { get; set; } = null;
  public int PermissaoId { get; set; }
  public Permissao Permissao { get; set; }
  public List<Sala> Salas { get; set; }
}