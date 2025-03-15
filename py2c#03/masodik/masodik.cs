for (int i = 0; i < 4; i++)
{
    Console.Write("Adja meg a jelenlegi összértéket: ");
    double ertek = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"A jelenlegi összérték {szamit(ertek):F2} db kosárba fér bele. ");
}

double szamit(double ertek)
{
    double kedvezmeny = 1;
    if (ertek >= 5000)
        kedvezmeny = 0.85;
    else if (ertek >= 4000)
        kedvezmeny = 0.90;
    else if (ertek >= 2000)
        kedvezmeny = 0.95;

    return Math.Round(ertek / 50 * kedvezmeny,2);
}