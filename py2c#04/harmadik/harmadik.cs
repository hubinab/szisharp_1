Building [] Epuletek;

using(StreamReader filebe = new StreamReader("legmagasabb.txt"))
{
    filebe.ReadLine();
    string[] sorok = filebe.ReadToEnd().Trim().Split("\n");
    Epuletek = new Building[sorok.Length];
    for (int i = 0; i < sorok.Length; i++)
    {
        string[] sor = sorok[i].Trim().Split(";");
        Building Epulet = new Building(sor[0], sor[1], sor[2], double.Parse(sor[3].Replace(",",".")), int.Parse(sor[4]), int.Parse(sor[5]));
        Epuletek[i] = Epulet;
    }
}

Console.WriteLine($"3.2 feladat: Épületek száma: {Epuletek.Length}");

int osszEmelet = 0;

for (int i = 0; i < Epuletek.Length; i++)
{
    osszEmelet += Epuletek[i].Emelet;
}

Console.WriteLine($"3.3 feladat: Emeletek összege: {osszEmelet}");

double legMagasabb = Epuletek[0].Magassag;
int legMagasabbIndex = 0;

for (int i = 1; i < Epuletek.Length; i++)
{
    if (legMagasabb < Epuletek[i].Magassag)
    {
        legMagasabb = Epuletek[i].Magassag;
        legMagasabbIndex = i;
    }
}

Console.WriteLine("3.4 feladat: A legmagasabb épület adatai");
Console.WriteLine($"\t Név: {Epuletek[legMagasabbIndex].Nev}");
Console.WriteLine($"\t Város: {Epuletek[legMagasabbIndex].Varos}");
Console.WriteLine($"\t Ország: {Epuletek[legMagasabbIndex].Orszag}");
Console.WriteLine($"\t Magasság: {Epuletek[legMagasabbIndex].Magassag}");
Console.WriteLine($"\t Emelet: {Epuletek[legMagasabbIndex].Emelet}");
Console.WriteLine($"\t Épült: {Epuletek[legMagasabbIndex].Epult}");

for (int i = 0; i < Epuletek.Length; i++)
{
    if (Epuletek[i].Orszag == "Olaszország")
    {
        Console.WriteLine("3.5 feladat: Van olasz épület az adatok között!");
        break;
    }
}
record Building(string Nev, string Varos, string Orszag, double Magassag, int Emelet, int Epult);