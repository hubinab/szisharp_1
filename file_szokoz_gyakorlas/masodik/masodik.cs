Contest[] Versenyzok;

using(StreamReader filebe = new StreamReader("pontszamok.txt"))
{
    string[] sorok = filebe.ReadToEnd().Trim().Split("\n");
    Versenyzok = new Contest[sorok.Length/2];

    int j = 0;
    for (int i = 1; i < sorok.Length; i+=2)
    {
        Versenyzok[j] = new Contest(sorok[i-1].Trim(), int.Parse(sorok[i]));
        j++;
    }
}

Console.WriteLine($"-------------------------------------");
Console.WriteLine($" {"Név",-30} {"Pont",-4} ");
Console.WriteLine($"-------------------------------------");
for (int i = 0; i < Versenyzok.Length; i++)
{
    Console.WriteLine($" {Versenyzok[i].Nev,-30}|{Versenyzok[i].Pont,4} ");
}
record Contest(string Nev, int Pont);