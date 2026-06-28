namespace Bauflaechenverwaltung;

public class Grundstueck
{
    public string Flurstuecknummer { get; set; } = string.Empty;
    public double Groesse { get; set; }
    public string Lage { get; set; } = string.Empty;
    public string AktuelleNutzung { get; set; } = string.Empty;
    public string Bebaubarkeit { get; set; } = string.Empty;
    public string BPlanNummer { get; set; } = string.Empty;
    public decimal Bodenrichtwert { get; set; }
    public string Eigentuemer { get; set; } = string.Empty;
    public List<Bauflaeche> Bauflaechen { get; set; } = new List<Bauflaeche>();
}