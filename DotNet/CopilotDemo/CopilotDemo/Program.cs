using System.Text.Json;

// luetaan tiedostosta "Luvut.txt" lukuja ja tulostetaan niiden summa
string[] rivit = File.ReadAllLines("Luvut.txt");
int summa = 0;
foreach (string rivi in rivit)
{
    int luku = int.Parse(rivi);
    summa += luku;
}
Console.WriteLine("Lukujen summa: " + summa);

// kirjoitetaan summa ja lukujen keskiarvo JSON-tiedostoon "Tulokset.json"
double keskiarvo = (double)summa / rivit.Length;
string json = JsonSerializer.Serialize(new { Summa = summa, Keskiarvo = keskiarvo });
File.WriteAllText("Tulokset.json", json);
