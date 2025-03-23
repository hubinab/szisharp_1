Console.Write("Kérem adjon meg egy szöveget: ");
string Szoveg = Console.ReadLine()!;

if (Szoveg.Length % 7 == 0)
{
    Console.WriteLine("A szöveg betűszáma osztható héttel!");
}
else
{
    Console.WriteLine("A szöveg betűszáma nem osztható héttel!");
}