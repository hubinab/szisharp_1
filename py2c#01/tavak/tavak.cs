Lakes [] tavaktomb;
using(StreamReader filebe = new StreamReader("alloviz.txt"))
{
    // Fejlec atugrasa
    filebe.ReadLine();
    // Teljes file beolvasasa a sorok string tombe, soronkent
    string[] sorok = filebe.ReadToEnd().Trim().Split("\n");
    // tavaktomb meretenek meghatarozasa (peldanyositas)
    tavaktomb = new Lakes[sorok.Length];
    // sorok vegig jarasa, egy-egy sor 
    // felbontasa tabulator menten mezokre
    // Egy sor egy lakes rekordba kerul
    // az osszes sor bekerul a tavaktomb-be
    for (int i = 0; i < tavaktomb.Length; i++)
    {
        // Egy sor felbontasa mezokre a sor string tombbe
        string[] sor = sorok[i].Trim().Split("\t");
        // Egy lakes peldanyositasa es feltoltese a mezokkel
        Lakes to = new Lakes(sor[0], sor[1], double.Parse(sor[2]), int.Parse(sor[3]));
        // Az igy letrehozott rekord betoltese a tavaktombbe
        tavaktomb[i] = to;
    }
}
Console.WriteLine("3.a feladat");
Console.WriteLine($"{tavaktomb.Length} tó adatait olvastuk be.");
Console.WriteLine();

double osszterulet = 0;

for (int i = 0; i < tavaktomb.Length; i++)
{
    osszterulet += tavaktomb[i].terulet;
}

Console.WriteLine("3.b feladat");
Console.WriteLine($"Magyarország {Math.Round((osszterulet / 93036) * 100, 2)} %-át fedik le a tavak.");
Console.WriteLine();

int LegnagyobbToIndex = 0;
int LegnagyobbTo = 0;

for (int i = 0; i < tavaktomb.Length; i++)
{
    if (LegnagyobbTo < tavaktomb[i].vizgyujto)
    {
        LegnagyobbTo = tavaktomb[i].vizgyujto;
        LegnagyobbToIndex = i;
    }
}

Console.WriteLine("3.c feladat");
Console.WriteLine($"A legnagyobb vízgyűjtő területű állóvíz: {tavaktomb[LegnagyobbToIndex].nev}");
Console.WriteLine($"\tTípusa: {tavaktomb[LegnagyobbToIndex].tipus}");
Console.WriteLine($"\tVízfelszíne: {tavaktomb[LegnagyobbToIndex].terulet} km2");
Console.WriteLine($"\tVízgyűjtő területe: {tavaktomb[LegnagyobbToIndex].vizgyujto} km2");
Console.WriteLine();

using (StreamWriter fileki = new("kozepes.txt"))
{
    for (int i = 0; i < tavaktomb.Length; i++)
    {
        if (tavaktomb[i].terulet >= 3 && tavaktomb[i].terulet <= 10 && tavaktomb[i].vizgyujto >= tavaktomb[i].terulet * 10)
        {
            fileki.WriteLine($"{tavaktomb[i].nev};{tavaktomb[i].tipus}");
        }
    }
}

record Lakes (string nev, string tipus, double terulet, int vizgyujto);