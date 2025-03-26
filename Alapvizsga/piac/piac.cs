Vasarlas[] vasarlasok;

using (StreamReader filebe = new StreamReader("nyugta.txt"))
{
    filebe.ReadLine();
    string[] adatok = filebe.ReadToEnd().Trim().Split('\n');
    vasarlasok = new Vasarlas[adatok.Length];
    for (int i = 0; i < adatok.Length; i++)
    {
        string[] adat = adatok[i].Trim().Split(';');
        vasarlasok[i] = new Vasarlas(adat[0], int.Parse(adat[1]), adat[2]);
    }
}

Console.WriteLine($"1. feladat: A fájlban {vasarlasok.Length} feleség adatai szerepelnek.");

int fegyverDb = 0;
int fegyverOssz = 0;

foreach (Vasarlas vasarlas in vasarlasok)
{
    if (vasarlas.Tetel == "fegyver")
    {
        fegyverDb++;
        fegyverOssz += vasarlas.Arkon;
    }
}

Console.WriteLine($"2. feladat: A fegyverekre költött összegek átlaga: {(double)fegyverOssz/fegyverDb:f2} arkhón.");

Vasarlas minVasarlas = vasarlasok[0];

foreach (Vasarlas vasarlas in vasarlasok)
{
    if (minVasarlas.Arkon > vasarlas.Arkon)
    {
        minVasarlas = vasarlas;
    }
}

Console.WriteLine("3. feladat: A legolcsóbb vásárlás adatai:");
Console.WriteLine($"\tNév: {minVasarlas.Nev}");
Console.WriteLine($"\tArkhón: {minVasarlas.Arkon}");
Console.WriteLine($"\tTétel: {minVasarlas.Tetel}");

Console.Write("4. feladat: Kérem adjon meg egy pozitív egész számot: ");
int ertekHatar = Convert.ToInt32(Console.ReadLine());

using (StreamWriter fileki = new StreamWriter("tetelek.txt"))
{
    fileki.WriteLine(ertekHatar);
    foreach (Vasarlas vasarlas in vasarlasok)
    {
        if (vasarlas.Arkon >= ertekHatar)
        {
            fileki.WriteLine($"{vasarlas.Nev}");
        }
    }
}

internal record Vasarlas (string Nev, int Arkon, string Tetel); 