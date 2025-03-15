for (int i = 0; i < 4; i++)
{
    Console.Write("Adja meg a betenni kívánt összeget: ");
    int osszeg = Convert.ToInt32(Console.ReadLine());
    Console.Write("Adja meg betét futamidejét (hónapban): ");
    int futamido = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"A betett összeg után {szamit(osszeg,futamido):F2} Ft betéti kamat jár.");
}

double szamit (int osszeg, int futamido)
{
    double kamat = 0;
    if (futamido > 12)
        kamat = 0.12;
    else
        kamat = 0.05;
    return Math.Round(osszeg * kamat, 2);
};

