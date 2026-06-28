namespace Bauflaechenverwaltung;

public enum FlaechenStatus
{
    Frei,
    Reserviert,
    Bebaut
}

public class Bauflaeche
{
    public string Id { get; set; } = string.Empty;
    public double Groesse { get; set; }
    public FlaechenStatus Status { get; set; } = FlaechenStatus.Frei;
}