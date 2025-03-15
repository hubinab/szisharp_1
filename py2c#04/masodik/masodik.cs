Console.WriteLine("2. feladat: Szökőév listázó");

Console.Write("Kérem az egyik évszámot: ");
int ev1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Kérem a másik évszámot: ");
int ev2 = Convert.ToInt32(Console.ReadLine());

int tmpev = ev1;
if (ev1 > ev2)
{
    ev1 = ev2;
    ev2 = tmpev;
}

bool van = false;
for (int i = ev1; i < ev2+1; i++)
{
    if (Szokoev(i))
    {
        if (!van)
        {
            van = true;
            Console.Write($"Szökőévek: {i}");
        }
        else
        {
            Console.Write($", {i}");
        }
    }
}

if (!van)
{
    Console.WriteLine("Nincs  szökőév  a  megadott  tartományban!");
}
else
{
    Console.WriteLine();
}

bool Szokoev (int ev)
{
    return ev % 400 == 0 || (ev % 4 == 0 && ev % 100 != 0);
}
