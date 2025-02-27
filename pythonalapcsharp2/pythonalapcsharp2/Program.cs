System.Console.WriteLine("1. feladat ----------- ");
System.Console.WriteLine("2. feladat ----------- ");

System.Console.WriteLine("3. feladat ----------- ");

Dictionary <string, string>[] SzotarLista = new Dictionary<string, string>[500];
int rekordokszama = 0;
using (StreamReader filebe = new("eredmenyek.txt", System.Text.Encoding.UTF8))
{
    for (int i = 0; !filebe.EndOfStream; i++, rekordokszama++)
    {
        SzotarLista[i] = new Dictionary<string, string> 
        {
            {"eredmeny", filebe.ReadLine()}
        };
    }
}

int Fekete = 0;
int Feher = 0;
int Dontetlen = 0;
for (int i = 0; i < rekordokszama; i++)
{
    if (SzotarLista[i]["eredmeny"] == "FK")
        Fekete += 1;
    if (SzotarLista[i]["eredmeny"] == "FH")
        Feher += 1;
    if (SzotarLista[i]["eredmeny"] == "XX")
        Dontetlen += 1;
}

using (StreamWriter fileki = new ("pontozotabla.txt", false, System.Text.Encoding.UTF8))
{
    fileki.WriteLine($"A 2040-es sakkolimpián a következő eredmények születtek:");
    fileki.WriteLine($"Az olimpián összesen {rekordokszama} partit játszottak a versenyzők egymással.");
    fileki.WriteLine($"Ezek lebontása a következő:");
    fileki.WriteLine($"Fehér színben játszva összesen {Feher} partit nyertek.");
    fileki.WriteLine($"Fekete színben játszva összesen {Fekete} partit nyertek.");
    fileki.WriteLine($"Döntetlent pedig összesen {Dontetlen} esetben játszottak.");
}

System.Console.WriteLine("Az állományba történt kiíratás megtörtént.");