Result[] eredmenyek;
using (StreamReader filebe = new StreamReader("eredmenyek.txt"))
{
    string[] sorok = filebe.ReadToEnd().Trim().Split("\n");
    eredmenyek = new Result[sorok.Length];
    for (int i = 0; i < sorok.Length; ++i)
    {
        string sor = sorok[i].Trim();
        eredmenyek[i] = new Result(sor);
    }
}

int Fekete = 0;
int Feher = 0;
int Dontetlen = 0;
for (int i = 0; i < eredmenyek.Length; i++)
{
    if (eredmenyek[i].Eredmeny == "FK")
        Fekete += 1;
    if (eredmenyek[i].Eredmeny == "FH")
        Feher += 1;
    if (eredmenyek[i].Eredmeny == "XX")
        Dontetlen += 1;
}

using (StreamWriter fileki = new StreamWriter("pontozotabla.txt"))
{
    fileki.WriteLine($"A 2040-es sakkolimpián a következő eredmények születtek:");
    fileki.WriteLine($"Az olimpián összesen {eredmenyek.Length} partit játszottak a versenyzők egymással.");
    fileki.WriteLine($"Ezek lebontása a következő:");
    fileki.WriteLine($"Fehér színben játszva összesen {Feher} partit nyertek.");
    fileki.WriteLine($"Fekete színben játszva összesen {Fekete} partit nyertek.");
    fileki.WriteLine($"Döntetlent pedig összesen {Dontetlen} esetben játszottak.");
}

record Result (string Eredmeny);
