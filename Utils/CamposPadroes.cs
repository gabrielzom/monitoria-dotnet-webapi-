public abstract class CamposPadroes {
  public int Id { get; set; }
  public DateTime CriadoEm { get; set; }
  public DateTime? AtualizadoEm { get; set; } = null;
  public string CriadoPor { get; set; }
  public string? AtualizadoPor { get; set; } = null;

}