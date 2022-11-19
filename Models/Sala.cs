public class Sala : CamposPadroes {
  public DateTime? FechadaEm { get; set; }
  public int ServidorId { get; set; }
  public Servidor Servidor { get; set; }
  public int JogoId { get; set; }
  public Jogo Jogo { get; set; }
  public List<Jogador> Jogadores { get; set; }

}