// 1. feladat téglalap
Console.Write("Add meg a téglalap első oldalát: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Add meg a téglalap másik oldalát: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}");
Console.WriteLine($"A téglalap területe: {a * b}");

// 2. feladat valós szám
Console.Write("Kérem az első valós számot: ");
double szam1 = double.Parse(Console.ReadLine());
Console.Write("Kérem a második valós számot: ");
double szam2 = double.Parse(Console.ReadLine());

Console.WriteLine($"A két szám összege: {szam1 + szam2}");
Console.WriteLine($"A két szám különbsége: {szam1 - szam2}");
Console.WriteLine($"A két szám szorzata: {szam1 * szam2}");

if (szam2 == 0)
{
    Console.WriteLine("Hiba! Nullával tilos osztani!");
}
else
{
    Console.WriteLine($"A két szám hányadosa: {szam1 / szam2}");
}

// 3. feladat születési év
Console.Write("Kérem a neved: ");
string Nev = Console.ReadLine();
Console.Write("Kérem a születési éved: ");
int Ev = int.Parse(Console.ReadLine());

if (Ev < 2000) { Console.WriteLine($"Jónapot {Nev}"); }
else
{
    Console.WriteLine($"Szia {Nev}");
}

// 4. feladat karácsony
Console.Write("Kérem az első ajándék összegét: ");
int aji1 = int.Parse(Console.ReadLine());
Console.Write("Kérem a második ajándék öszegét: ");
int aji2 = int.Parse(Console.ReadLine());
Console.Write("Kérem a harmadik ajándék összegét: ");
int aji3 = int.Parse(Console.ReadLine());
int ajiossz = aji1 + aji2 + aji3;

if (ajiossz <= 20000)
{
    Console.WriteLine($"Maradt még: {20000 - ajiossz}");
}
else
{
    Console.WriteLine($"Túllépted: {ajiossz - 20000}");
}

// 5. feladat pénzfeldobás

Random penz = new Random();

if (penz.Next(2) == 0)
{
    Console.WriteLine("fej");
}
else
{
    Console.WriteLine("írás");
}

// 6. feladat páros/páratlan
Console.Write("Kérek egy számot: ");
int szam = int.Parse(Console.ReadLine());

if (szam % 2 == 0)
{
    Console.WriteLine("Páros");
}
else
{
    Console.WriteLine("Páratlan");
}

// 7. feladat programozó
Console.Write("Szeretnél 5-öst kapni programozásból?(igen/nem) ");
string valasz = Console.ReadLine();

if (valasz == "igen") { Console.WriteLine("Akkor gyakorolj!"); } else { Console.WriteLine("Helytelen a hozzáállásod!"); }

// 8. feladat pozitív/negatív/nulla
Console.Write("Kérek egy számot: ");
int szam3 = int.Parse(Console.ReadLine());

if (szam3 == 0)
{
    Console.WriteLine("nulla");
}
else
{
    if (szam3 < 0)
    {
        Console.WriteLine("negatív");
    }
    else
    {
        Console.WriteLine("pozitív");
    }
};

// 9. feladat hónapok/évszakok
Console.Write("Add meg egy hónap számát (1-12): ");
int ho = int.Parse(Console.ReadLine());

if (ho == 3 || ho == 4 || ho == 5)
{
    Console.WriteLine("tavasz");
}

if (ho == 6 || ho == 7 || ho == 8)
{
    Console.WriteLine("nyár");
}

if (ho == 9 || ho == 10 || ho == 11)
{
    Console.WriteLine("ősz");
}

if (ho == 12 || ho == 1 || ho == 2)
{
    Console.WriteLine("tél");
}

// 10. feladat szökőév
Console.Write("Adjon meg egy évszámot (1-3000): ");
int ev = int.Parse(Console.ReadLine());

if ((ev % 4 == 0 && ev % 400 == 0) || (ev % 4 == 0 && ev % 100 != 0))
{
    Console.WriteLine("Szökőév");
}
else
{
    Console.WriteLine("Nem szökőév");
}

// 11. feladat melyik a legnagyobb szám
Console.Write("Add meg az első számot: ");
int szam4 = int.Parse(Console.ReadLine());
Console.Write("Add meg a második számot: ");
int szam5 = int.Parse(Console.ReadLine());
Console.Write("Add meg a harmadik számot: ");
int szam6 = int.Parse(Console.ReadLine());

int legnagyobbszam = szam4;

if (szam5 > legnagyobbszam) { legnagyobbszam = szam5; };
if (szam6 > legnagyobbszam) { legnagyobbszam = szam6; };

Console.WriteLine($"A legnagyobb szám: {legnagyobbszam}");

// 12. feladat leárazás
Console.Write("Adja meg a termék árát: ");
int ar = int.Parse(Console.ReadLine());
Console.Write("Adja meg az akció mértékét %-ban: ");
int akcio = int.Parse(Console.ReadLine());

Console.WriteLine($"Akciós ár: {ar * ((100 - akcio) / 100.0)}");

if (akcio > 50)
{
    Console.WriteLine("Megéri az árát!!!!");
}

// 13. feladat víz hőmérséklete
Console.Write("Adja meg a víz hőmérsékletét: ");
ho = int.Parse(Console.ReadLine());

if (ho < 0)
    Console.WriteLine("Jég!");
if (ho > 0 && ho < 100)
    Console.WriteLine("Folyékony!");
if (ho > 100)
    Console.WriteLine("Gőz!");

// 14. feladat rendezés (ez még nem jó!)
int tmpszam;
Console.Write("Add meg az első számot: ");
int szam7 = int.Parse(Console.ReadLine());
Console.Write("Add meg a második számot: ");
int szam8 = int.Parse(Console.ReadLine());
Console.Write("Add meg a harmadik számot: ");
int szam9 = int.Parse(Console.ReadLine());

if (szam7 > szam8)
{
    tmpszam = szam7;
    szam7 = szam8;
    szam8 = tmpszam;
}

if (szam7 > szam9)
{
    tmpszam = szam7;
    szam7 = szam9;
    szam9 = tmpszam;
}

if (szam8 > szam9)
{
    tmpszam = szam8;
    szam8 = szam9;
    szam9 = tmpszam;
}
Console.WriteLine($"A számok sorrendje3: {szam7}, {szam8}, {szam9}");

// 15. feladat gének
Console.Write("Adja meg az első génpárját (a/b/0): ");
string gen1 = Console.ReadLine();
Console.Write("Adja meg a második génpárját (a/b/0): ");
string gen2 = Console.ReadLine();

string gen = gen1  + gen2;

if  (gen == "aa" || gen == "a0" || gen == "0a")
    Console.WriteLine("A vércsoportod A");

if (gen == "bb" || gen == "b0" || gen == "0b")
    Console.WriteLine("A vércsoportod B");

if (gen == "ab" || gen == "ba")
    Console.WriteLine("A vércsoportod AB");

if (gen == "00")
    Console.WriteLine("A vércsoportod 0");

