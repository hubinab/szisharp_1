Vasarlas[] vasarlasok;

using (var filebe = new StreamReader("nyugta.txt"))
{
    filebe.ReadLine();
    var adatok = filebe.ReadToEnd().Trim().Split('\n');
    vasarlasok = new Vasarlas[adatok.Length];
    for (var i = 0; i < adatok.Length; i++)
    {
        var adat = adatok[i].Trim().Split(';');
        vasarlasok[i] = new Vasarlas(adat[0], int.Parse(adat[1]), adat[2]);
    }
}

Console.WriteLine($"1. feladat: A fájlban {vasarlasok.Length} feleség adatai szerepelnek.");

var fegyverDb = 0;
var fegyverOssz = 0;

foreach (var vasarlas in vasarlasok)
{
    if (vasarlas.Tetel == "fegyver")
    {
        fegyverDb++;
        fegyverOssz += vasarlas.Arkon;
    }
}

Console.WriteLine($"2. feladat: A fegyverekre költött összegek átlaga: {(double)fegyverOssz/fegyverDb:f2} arkhón.");

var minVasarlas = vasarlasok[0];

foreach (var vasarlas in vasarlasok)
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
var ertekHatar = Convert.ToInt32(Console.ReadLine());

using (var fileki = new StreamWriter("tetelek.txt"))
{
    fileki.WriteLine(ertekHatar);
    foreach (var vasarlas in vasarlasok)
    {
        if (vasarlas.Arkon >= ertekHatar)
        {
            fileki.WriteLine($"{vasarlas.Nev}");
        }
    }
}

internal record Vasarlas (string Nev, int Arkon, string Tetel); 