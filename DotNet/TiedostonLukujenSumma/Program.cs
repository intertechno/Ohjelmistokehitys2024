string[] rivit = File.ReadAllLines("Luvut.txt");
int lkm = 0;
int summa = 0;

foreach (string rivi in rivit)
{
    int luku = int.Parse(rivi);

    summa += luku;
    lkm++;
}

Console.WriteLine("Tiedoston lukujen summa on: " + summa);
float keskiarvo = summa / lkm;
Console.WriteLine("Tiedoston lukujen keskiarvo on: " + keskiarvo);
