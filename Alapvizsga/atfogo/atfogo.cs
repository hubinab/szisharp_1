double PythagorasTetel(double a, double b)
{
    return Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)),1);
}

for (int i = 0; i < 5; i++)
{
    Console.Write("Kérem adja meg az 'a' befogó oldal hosszát: ");
    double aoldal = Convert.ToDouble(Console.ReadLine());
    Console.Write("Kérem adja meg a 'b' befogó oldal hosszát: ");
    double boldal = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"A 'c' átló hossza: {PythagorasTetel(aoldal, boldal)}");
}