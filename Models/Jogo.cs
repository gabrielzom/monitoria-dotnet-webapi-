public class Jogo : CamposPadroes {
  public string Titulo { get; set; }
  public double Valor { get; set; }
  public int FaixaEtaria { get; set; }
  public int GeneroId { get; set; }
  public Genero Genero { get; set; }
}