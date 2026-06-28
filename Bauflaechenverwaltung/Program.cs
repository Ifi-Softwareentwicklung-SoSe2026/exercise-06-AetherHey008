using Bauflaechenverwaltung;

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

Console.WriteLine($"Grundstück: {grundstueck.Flurstuecknummer}, Eigentümer: {grundstueck.Eigentuemer}");
Console.WriteLine($"B-Plan: {grundstueck.BPlanNummer}, Bodenrichtwert: {grundstueck.Bodenrichtwert}€/m²");
Console.WriteLine($"Anzahl Bauflächen: {grundstueck.Bauflaechen.Count}");
foreach (var bf in grundstueck.Bauflaechen)
{
    Console.WriteLine($"- Fläche {bf.Id}: {bf.Groesse}m², Status: {bf.Status}");
}