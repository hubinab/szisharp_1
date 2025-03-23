Buy[] Vasarlasok;

using(StreamReader filebe = new StreamReader("nyugta.txt"))
{
    filebe.ReadLine();
    string[] sorok = filebe.ReadToEnd().Trim().Split('\n');
    Vasarlasok = new Buy[sorok.Length];

    for (int i = 0; i < sorok.Length; i++)
    {
        string[] sor = sorok[i].Trim().Split(";");
        Buy Vasarlas = new Buy(sor[0], int.Parse(sor[1]), sor[2]);
        Vasarlasok[i] = Vasarlas;
    }
}

Console.WriteLine($"Az állomány {Vasarlasok.Length} vásárlás adatait tartalmazza.");

int kenyerDB = 0;

for (int i = 0; i < Vasarlasok.Length; i++)
{
    if (Vasarlasok[i].Tetel == "kenyér")
    {
        kenyerDB++;
    }
}

Console.WriteLine($"Összesen {kenyerDB} feleség vásárolt kenyeret.");

int osszzeg = 0;

for (int i = 0; i < Vasarlasok.Length; i++)
{
    if (Vasarlasok[i].Nev.Length % 2 == 0)
    {
        osszzeg += Vasarlasok[i].Arkhon;
    }
}

Console.WriteLine($"Páros név összeg: {osszzeg}");

Console.Write("Kérem adjon meg egy ógörög spártában is használt nevet: ");
string nevBe = Console.ReadLine();

//bool voltE = false;

//for (int i = 0;i < Vasarlasok.Length; i++)
//{
//    if (Vasarlasok[i].Nev == nevBe)
//    {
//        voltE = true;
//        Console.WriteLine($"Volt {nevBe} nevű vásárló az adatok között.");
//        break;
//    }
//}

int j = 0;

for (; j < Vasarlasok.Length && Vasarlasok[j].Nev != nevBe; j++);

if (j < Vasarlasok.Length)
{
    Console.WriteLine($"Volt {nevBe} nevű vásárló az adatok között.");
} else
{
    Console.WriteLine($"Nem volt {nevBe} nevű vásárló az adatok között.");
}



int legOlcsobb = int.MaxValue;
int legDragabb = 0;

int legOlcsobbIndex = 0;
int legDragabbIndex = 0;

for (int i = 0; i < Vasarlasok.Length; i++)
{
    if (Vasarlasok[i].Arkhon < legOlcsobb)
    {
        legOlcsobb = Vasarlasok[i].Arkhon;
        legOlcsobbIndex = i;
    }

    if (Vasarlasok[i].Arkhon > legDragabb)
    {
        legDragabb = Vasarlasok[i].Arkhon;
        legDragabbIndex = i;
    }
}


Console.WriteLine("A legolcsóbb vásárlás adatai:");
Console.WriteLine($"\tNév: {Vasarlasok[legOlcsobbIndex].Nev}");
Console.WriteLine($"\tArkhón: {Vasarlasok[legOlcsobbIndex].Arkhon}");
Console.WriteLine($"\tTétel: {Vasarlasok[legOlcsobbIndex].Tetel}");

Console.WriteLine("A legdrágább vásárlás adatai:");
Console.WriteLine($"\tNév: {Vasarlasok[legDragabbIndex].Nev}");
Console.WriteLine($"\tArkhón: {Vasarlasok[legDragabbIndex].Arkhon}");
Console.WriteLine($"\tTétel: {Vasarlasok[legDragabbIndex].Tetel}");


Console.Write("Kérem adjon meg a pozitív egész számot: ");
int szam = Convert.ToInt32(Console.ReadLine());

using(StreamWriter fileki = new StreamWriter("tetelek.txt"))
{
    fileki.WriteLine(szam);
    for (int i = 0; i < Vasarlasok.Length; i++)
    {
        if (Vasarlasok[i].Arkhon >= szam)
        {
            fileki.WriteLine(Vasarlasok[i].Nev);
        }
    }
}

record Buy (string Nev, int Arkhon, string Tetel);