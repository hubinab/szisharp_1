Movie[] Mozik;

using(StreamReader filebe = new StreamReader("mozi_stat.txt"))
{
    filebe.ReadLine();
    string [] sorok = filebe.ReadToEnd().Trim().Split("\n");
    Mozik = new Movie[sorok.Length];
    for (int i = 0; i < sorok.Length; i++)
    {
        string[] sor = sorok[i].Trim().Split(";");
        Mozik[i] = new Movie(int.Parse(sor[0]), int.Parse(sor[1]), int.Parse(sor[2]), int.Parse(sor[3]),
                             int.Parse(sor[4]), int.Parse(sor[5]), int.Parse(sor[6]), int.Parse(sor[7]));
    }
}
double Latogatottsag = 0;
for (int i = 0; i < Mozik.Length; i++)
{
    Latogatottsag += Mozik[i].Latogatas;
}
Console.WriteLine($"1.feladat: A magyar mozik átlagos látogatottsága: {Latogatottsag/Mozik.Length/1000:F2} millió néző");

int KettoOtven = 0;
for (int i = 0; i < Mozik.Length; i++)
{
    if (Mozik[i].Film >= 250)
    {
        KettoOtven++;
    }
}

Console.WriteLine($"2.feladat: Legalább 250 filmet {KettoOtven} évben mutattak be.");

for (int i = 0; i < Mozik.Length; i++)
{
    if (Mozik[i].Jegyar * Mozik[i].Latogatas * 1000 <= 10000000000)
    {
        Console.WriteLine("3.feladat: Volt 10 milliárd forintnál kisebb árbevételű év.");
        break;
    }
}

int LegTobbMagyarIndex = 0;
double MaxArany = 0;
for (int i = 0; i < Mozik.Length; i++)
{
    if (MaxArany < (double)Mozik[i].MagyarFilm / Mozik[i].Film)
    {
        MaxArany = (double)Mozik[i].MagyarFilm / Mozik[i].Film;
        LegTobbMagyarIndex = i;
    }
}

Console.WriteLine($"4.feladat: Legtöbb magyar film {MaxArany*100:F1} % - {Mozik[LegTobbMagyarIndex].Ev}");

// Év;Mozi;Befogadóképesség;Előadás;Látogatás;Átlagos jegyár;Bemutatott játékfilm;Magyar játékfilm
record Movie(int Ev, int Mozi, int Befog, int Eloadas, int Latogatas, int Jegyar, int Film, int MagyarFilm);