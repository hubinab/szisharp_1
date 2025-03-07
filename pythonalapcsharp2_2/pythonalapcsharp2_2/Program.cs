using System.Diagnostics.Metrics;

namespace pythonalapcsharp2_2
{
    internal class Program
    {
        record eredmeny (string Eredmeny);
        static void Main(string[] args)
        {
            int rekordszam = 0;
            eredmeny[] eredmenyek = new eredmeny[100];
            using (StreamReader filebe = new("eredmenyek.txt"))
            {
                for (int i = 0; !filebe.EndOfStream; ++i)
                {
                    string line = filebe.ReadLine().Trim();
                    eredmenyek[i] = new eredmeny(line);
                    rekordszam++;
                }
            }

            int Fekete = 0;
            int Feher = 0;
            int Dontetlen = 0;
            for (int i = 0; i<rekordszam; i++)
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
                fileki.WriteLine($"Az olimpián összesen {rekordszam} partit játszottak a versenyzők egymással.");
                fileki.WriteLine($"Ezek lebontása a következő:");
                fileki.WriteLine($"Fehér színben játszva összesen {Feher} partit nyertek.");
                fileki.WriteLine($"Fekete színben játszva összesen {Fekete} partit nyertek.");
                fileki.WriteLine($"Döntetlent pedig összesen {Dontetlen} esetben játszottak.");
            }
        }
    }
}
