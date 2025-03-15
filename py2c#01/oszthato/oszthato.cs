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
