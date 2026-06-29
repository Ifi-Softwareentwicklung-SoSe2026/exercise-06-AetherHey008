using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using Bauflaechenverwaltung;
namespace RechtsVerwaltung;
public enum Nutzer1
{
    Bauamtsmitarbeiter,
    Antragsteller,
    Gutachter
}

static class RechtsVerwaltungclass
{
    public static string Ausgabe { get; set; } = string.Empty;
    public static string BeschreibeGrundstueck(this Nutzer1 n1)
    {
        var grundstueck = new Grundstueck();
        string s1 = ($"Grundstück: {grundstueck.Flurstuecknummer}, Eigentümer: {grundstueck.Eigentuemer}");
        string s2 = ($"B-Plan: {grundstueck.BPlanNummer}, Bodenrichtwert: {grundstueck.Bodenrichtwert}€/m²");
        string s3 = ($"Anzahl Bauflächen: {grundstueck.Bauflaechen.Count}");
        var builder = new System.Text.StringBuilder();
        

        foreach (var bf in grundstueck.Bauflaechen)
        {
            builder.AppendLine($"- Fläche {bf.Id}: {bf.Groesse}m², Status: {bf.Status}");
        }
        
        switch (n1)
        {
            case Nutzer1.Bauamtsmitarbeiter:
                return builder.ToString();;
            case Nutzer1.Antragsteller:
                return s1;
            case Nutzer1.Gutachter:
                return s1 + builder;
            default:
                return "Bitte einen Gueltigen user eingeben";
        }
        
    }

   
}
