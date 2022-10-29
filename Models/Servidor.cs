public class Servidor : CamposPadroes {
  public string Nome { get; set; }
  public Regiao Regiao { get; set; }
  public string IpPublico { get; set; }
  public string IpPrivado { get; set; }
  public SistemaOperacional SistemaOperacional { get; set; }
  public int BancoDadosId { get; set; }
  public BancoDados BancoDados { get; set; }
}