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
