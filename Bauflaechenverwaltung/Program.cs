using System;
using Bauflaechenverwaltung;
using RechtsVerwaltung;

public enum Nutzer
{
    Bauamtsmitarbeiter,
    Antragsteller,
    Gutachter
}
class Programm
{
    static void Main(string[] args)
    {
        var grundstueck = new Grundstueck
        {
            Flurstuecknummer = "0015 00012 001/002",
            Groesse = 1200.5,
            Lage = "Leipzig-Nord",
            AktuelleNutzung = "Brachfläche",
            Bebaubarkeit = "ja",
            BPlanNummer = "BP-2022-089 – Wohngebiet Leipzig-Nord",
            Bodenrichtwert = 500m,
            Eigentuemer = "Max Mustermann"
        };

        var flaeche1 = new Bauflaeche { Id = "BF1", Groesse = 500, Status = FlaechenStatus.Frei };
        var flaeche2 = new Bauflaeche { Id = "BF2", Groesse = 700, Status = FlaechenStatus.Reserviert };

        grundstueck.Bauflaechen.Add(flaeche1);
        grundstueck.Bauflaechen.Add(flaeche2);

       
        Console.Write("Nutzer eingeben: ");
        string eingabe = Console.ReadLine() ?? string.Empty;
        if (!Enum.TryParse<Nutzer1>(eingabe, true, out var nutzer))
        {
            Console.WriteLine("Ungültiger Nutzer. Standard: Antragsteller");
            nutzer = Nutzer1.Antragsteller;
        }
        string ausgabe = RechtsVerwaltungclass.BeschreibeGrundstueck(nutzer);
        Console.WriteLine(ausgabe);



    }
}
