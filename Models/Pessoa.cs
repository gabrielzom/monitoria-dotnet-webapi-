public class Pessoa : CamposPadroes {
  public string Nome { get; set; }
  public string Sobrenome { get; set; }
  public DateTime Nascimento { get; set; }
  public string Email { get; set; }
  public string Usuario { get; set; }
  public string Senha { get; set; }
  public List<Sala> Salas { get; set; }
}