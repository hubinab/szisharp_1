Fruit[] Gyumolcsok;

using(StreamReader filebe = new StreamReader("gyumolcsok.txt"))
{
    string [] sorok = filebe.ReadToEnd().Trim().Split("\n");
    Gyumolcsok = new Fruit[sorok.Length];

    for (int i = 0; i < sorok.Length; i++)
    {
        string [] sor = sorok[i].Trim().Split(";");
        Gyumolcsok[i] = new Fruit(sor[0], int.Parse(sor[1]));
    }
}

int OsszTomeg = 0;
int TizKiloDb = 0;
string HarmincKiloNevek = "";
int Legtobb = 0;
string LegtobbGyumi = "";
string TiznelKisebb = "";
bool vanTiznelKisebb = false;
foreach (var Gyumi in Gyumolcsok)
{
    Console.WriteLine($"{Gyumi.Nev,-15}({Gyumi.Tomeg,2} kg)");
    OsszTomeg += Gyumi.Tomeg;
    if (Gyumi.Tomeg == 10)
    {
        TizKiloDb++;
    }
    if (Gyumi.Tomeg >= 30)
    {
        HarmincKiloNevek += " " + Gyumi.Nev + ",";
    }
    if (Legtobb < Gyumi.Tomeg)
    {
        LegtobbGyumi = Gyumi.Nev;
        Legtobb = Gyumi.Tomeg;
    }
    if (Gyumi.Tomeg < 10 && !vanTiznelKisebb)
    {
        TiznelKisebb = Gyumi.Nev;
        vanTiznelKisebb = true;
    }

}

Console.WriteLine($"Összesen {OsszTomeg} kg gyümölcs termett.");
Console.WriteLine($"Átlagossan {OsszTomeg*1.0/Gyumolcsok.Length:F2}");
Console.WriteLine($"Összesen {TizKiloDb} gyümölcsből termett pontosan 10 kg.");
Console.WriteLine($"Idén a legtöbbet termő gyümolcs neve: {LegtobbGyumi}.");
Console.WriteLine($"Azon gyümölcsök nevei, amelyekből legalább 30 kg termett: {HarmincKiloNevek[1..^1]}.");
if (vanTiznelKisebb)
{
    Console.WriteLine($"A tíz kg-nál kevesebbet termő első gyümölcs neve: {TiznelKisebb}.");
}


record Fruit(string Nev, int Tomeg);
