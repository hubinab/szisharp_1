Student [] Tanulok;

using(StreamReader filebe = new StreamReader("adatok.txt"))
{
    string [] sorok = filebe.ReadToEnd().Trim().Split("\n");
    Tanulok = new Student [sorok.Length];

    for (int i = 0; i < sorok.Length; i++)
    {
        string [] sor = new string[3];
        sor[0] = sorok[i].Substring(0, 4);
        sor[1] = sorok[i].Substring(5, 1);
        sor[2] = sorok[i].Substring(7).Trim();
        Tanulok[i] = new Student(int.Parse(sor[0]), Convert.ToChar(sor[1]), sor[2]);
    }
}

Console.WriteLine($"Összesen {Tanulok.Length} diák adatai kerültek rögzítésre.");

record Student(int Datum, char Osztaly, string Nev);
