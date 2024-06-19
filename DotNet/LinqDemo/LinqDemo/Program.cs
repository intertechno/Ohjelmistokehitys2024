using LinqDemo;

// listään esimerkkihenkilöitä eri maista
List<Henkilö> henkilöt =
[
    new Henkilö { Nimi = "Matti Meikäläinen", Osoite = "Mannerheimintie 1", Maa = "Suomi" },
    new Henkilö { Nimi = "Maija Meikäläinen", Osoite = "Mannerheimintie 1", Maa = "Suomi" },
    new Henkilö { Nimi = "John Doe", Osoite = "123 Main St", Maa = "USA" },
    new Henkilö { Nimi = "Anna Svensson", Osoite = "Storgatan 2", Maa = "Ruotsi" },
    new Henkilö { Nimi = "Hans Müller", Osoite = "Hauptstraße 5", Maa = "Saksa" },
    new Henkilö { Nimi = "Marie Dubois", Osoite = "Rue de la Paix 10", Maa = "Ranska" },
    new Henkilö { Nimi = "Giovanni Rossi", Osoite = "Via Roma 20", Maa = "Italia" },
    new Henkilö { Nimi = "Pablo García", Osoite = "Calle Mayor 15", Maa = "Espanja" },
    new Henkilö { Nimi = "Lars Hansen", Osoite = "Nørregade 7", Maa = "Tanska" },
    new Henkilö { Nimi = "Emma Wilson", Osoite = "Church St 3", Maa = "Iso-Britannia" },
    new Henkilö { Nimi = "Scott Wilson", Osoite = "Church St 3", Maa = "Iso-Britannia" },
    new Henkilö { Nimi = "Yuki Tanaka", Osoite = "Shibuya 1-2", Maa = "Japani" },
    new Henkilö { Nimi = "Chen Wei", Osoite = "Nanjing Lu 88", Maa = "Kiina" },
    new Henkilö { Nimi = "Carlos Silva", Osoite = "Avenida Paulista 100", Maa = "Brasilia" },
    new Henkilö { Nimi = "Olga Petrova", Osoite = "Arbat 12", Maa = "Venäjä" },
    new Henkilö { Nimi = "Ahmed Hassan", Osoite = "Tahrir Square 50", Maa = "Egypti" },
    new Henkilö { Nimi = "Ayesha Khan", Osoite = "MG Road 15", Maa = "Intia" }
];

// kysytään käyttäjältä maata, ja listataan sen maan henkilöt
Console.Write("Anna maa: ");
string maa = Console.ReadLine() ?? "";

// LINQ-kysely metodisyntaksilla (method syntax)
var maanHenkilöt = henkilöt.Where(h => h.Maa == maa);

// LINQ-kysely kyselysyntaksilla (query syntax)
var maanHenkilöt2 = from h in henkilöt
                    where h.Maa == maa
                    select h;

foreach (var henkilö in maanHenkilöt)
{
    Console.WriteLine($"{henkilö.Nimi}, {henkilö.Osoite}");
}
