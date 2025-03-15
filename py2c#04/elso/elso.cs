Console.WriteLine("1. feladat: Kisebb-nagyobb meghatározása");
Console.Write("Kérem az első számot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérem a második számot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());

if (szam1 == szam2)
    Console.WriteLine("A két szám egyenlő.");
else if (szam1 < szam2)
    Console.WriteLine($"A nagyobb szám {szam2}, a kisebb {szam1}.");
else
    Console.WriteLine($"A nagyobb szám {szam1}, a kisebb {szam2}.");
