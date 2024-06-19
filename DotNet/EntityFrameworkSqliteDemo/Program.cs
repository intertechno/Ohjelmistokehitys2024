using EntityFrameworkSqliteDemo;

Console.WriteLine("Aloitetaan SQLite-tietokannan käsittely.");

// tietojen lisääminen
HenkilotContext context = new();
/*
context.Add(new Henkilot() {
  HenkiloId = 1,
  Nimi = "Anna Svensson",
  Osoite = "Storgatan 2",
  Maa = "Ruotsi"
});
context.SaveChanges();
*/

// tietojen hakeminen
var suomalaiset = context.Henkilots.Where(h => h.Maa == "Suomi");
foreach (var suomalainen in suomalaiset)
{
    Console.WriteLine(suomalainen.Nimi);
}

Console.WriteLine("SQLite-tietokannan käsittely on päättynyt.");
