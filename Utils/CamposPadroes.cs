public abstract class CamposPadroes {
  public int Id { get; set; }
  public DateTime CriadoEm { get; set; }
  public DateTime? AtualizadoEm { get; set; } = null;
  public int CriadoPor { get; set; }
  public int? AtualizadoPor { get; set; } = null;

}