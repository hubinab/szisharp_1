Console.WriteLine("1. feladat -----------------");
Console.Write("Add meg az első számot! ");
int szam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Add meg a második számot! ");
int szam2 = Convert.ToInt32(Console.ReadLine());

if (szam1 == szam2)
{
    Console.WriteLine("Az első szám egyenlő a másodikkal, és oszthatók egymással.");
}
else
{
    if (szam1 % szam2 == 0)
    {
        Console.WriteLine("Az első szám osztható a második számmal.");
    }
    if (szam2 % szam1 == 0)
    {
        Console.WriteLine("A második szám osztható az első számmal.");
    }
    if (szam1 % szam2 != 0 && szam2 % szam1 != 0)
    {
        Console.WriteLine("A számok nem oszthatók egymással.");
    }
}

Console.WriteLine("2. feladat -----------------");

Random random = new();

Console.Write("Add meg a telkek számát: ");
int telkekszama = int.Parse(Console.ReadLine());
for (int i = 0; i < telkekszama; i++)
{
    int a = random.Next(20,100);
    int b = random.Next(20,100);
    int negyszogol = terulet(a, b);
    Console.WriteLine($"{i + 1}. telek:");
    Console.WriteLine($"\toldalai: {a} és {b} m");
    Console.WriteLine($"\tterülete: {negyszogol} négyszögöl");
    if (negyszogol<1000)
    {
        Console.WriteLine($"\tTúl kicsi a telek!");
    }
}

int terulet (int a, int b)
{
    return Convert.ToInt32(Math.Round(a * b / 3.6, 0));
}

Console.WriteLine("3. feladat -----------------");


Dictionary<string, string> [] szotarlista = new Dictionary<string, string> [200];
int rekordokszama = 0;
using (StreamReader filebe = new StreamReader ("alloviz.txt"))
{
    filebe.ReadLine();
    //for (int i = 0; filebe.EndOfStream != true; i++, rekordokszama++)
    //for (int i = 0; filebe.EndOfStream == false; i++, rekordokszama++)
    for (int i = 0; !filebe.EndOfStream; i++, rekordokszama++)
    {
        string [] adat = filebe.ReadLine().Split('\t');

        // adat [0] = "Gyova-Mámai-Holt-Tisza";
        // adat [1] = "morotvató";
        // adat [2] = "1.33";
        // adat [3] = "35";

        szotarlista[i] = new Dictionary<string, string> 
        {
            {"nev",adat[0]}, 
            {"tipus",adat[1]}, 
            {"terulet",adat[2]/*.Replace('.',',') - Apple-nél nem kell*/}, 
            {"vizgyujto",adat[3]}
        };
        // rekordokszama = i;
        // rekordokszama++;
        // rekordokszama += 1;
    }
}

Console.WriteLine("3.a feladat");
Console.WriteLine($"{rekordokszama} tó adatait olvastuk be.");
Console.WriteLine();

double osszterulet = 0;

for (int i = 0; i < rekordokszama; i++)
{
    osszterulet += double.Parse(szotarlista[i]["terulet"]);
}

Console.WriteLine("3.b feladat");
Console.WriteLine($"Magyarország {Math.Round((osszterulet / 93036) * 100, 2)} %-át fedik le a tavak.");
Console.WriteLine();

int LegnagyobbToIndex = 0;
int LegnagyobbTo = 0;

for (int i = 0; i < rekordokszama; i++)
{
    if (LegnagyobbTo < int.Parse(szotarlista[i]["vizgyujto"]))
    {
        LegnagyobbTo = int.Parse(szotarlista[i]["vizgyujto"]);
        LegnagyobbToIndex = i;
    }
}

Console.WriteLine("3.c feladat");
Console.WriteLine($"A legnagyobb vízgyűjtő területű állóvíz: {szotarlista[LegnagyobbToIndex]["nev"]}");
Console.WriteLine($"\tTípusa: {szotarlista[LegnagyobbToIndex]["tipus"]}");
Console.WriteLine($"\tVízfelszíne: {szotarlista[LegnagyobbToIndex]["terulet"]} km2");
Console.WriteLine($"\tVízgyűjtő területe: {szotarlista[LegnagyobbToIndex]["vizgyujto"]} km2");
Console.WriteLine();

Console.WriteLine("4. feladat -----------------");

using (StreamWriter fileki = new("kozepes.txt"))
{
    for (int i = 0; i < rekordokszama; i++)
    {
        if (double.Parse(szotarlista[i]["terulet"]) >= 3 && double.Parse(szotarlista[i]["terulet"]) <= 10 && int.Parse(szotarlista[i]["vizgyujto"]) >= double.Parse(szotarlista[i]["terulet"]) * 10)
        {
            fileki.WriteLine($"{szotarlista[i]["nev"]};{szotarlista[i]["tipus"]}");
        }
    }
}

Console.ReadKey();