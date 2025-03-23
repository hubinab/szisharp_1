double TeglalapTerulete (double a, double b)
{
    return Math.Round(a * b / 10000000000,12);
}


for (int i = 0; i < 5; i++)
{
    Console.Write("Kérem adja be az 'a' oldalt: ");
    double aOldal = Convert.ToDouble(Console.ReadLine());

    Console.Write("Kérem adja be a 'b' oldalt: ");
    double bOldal = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"A megadott oldalakhoz tartozó téglalamp {TeglalapTerulete(aOldal, bOldal):F12} km2 területű!");
}