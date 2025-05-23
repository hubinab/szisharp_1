// Betű-szám

Console.Write("Kérem adjon meg egy szót: ");
string szo = Console.ReadLine();
Console.WriteLine($"A karakterek száma {(szo!.Length % 2 == 0?"páros":"páratlan")}");

// Átfogó
double PythagorasTetel(double a, double b)
{
    return Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)),1);
}
