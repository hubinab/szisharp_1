using Data;
using Logic;

namespace Hajoflotta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hajok Logic = new Hajok();
            using (StreamReader fileBe = new StreamReader("hajok.txt"))
            { 
                fileBe.ReadLine();
                string[] sorok = fileBe.ReadToEnd().Trim().Split('\n');
                foreach (var sor in sorok)
                {
                    string[] egySor = sor.Trim().Split(";");
                    Logic.AddHajo(egySor[0], egySor[1], int.Parse(egySor[2]), int.Parse(egySor[3]), int.Parse(egySor[4]), egySor[5], int.Parse(egySor[6]));
                }
            }
            Console.WriteLine($"1. Igény: Hajók száma: {Logic.darab} darab");
            
            Console.WriteLine($"2. Igény: Az éttermek átlag kapacitása: {Logic.FlottaEttermiKapacitasa()} fő");

            Console.Write("4. Igény: Kérem adja meg a jelleg nevét: ");
            string jelleg = Console.ReadLine();
            var jellegSzerintLegregebbi = Logic.JellegSzerintLegregebbi(jelleg);
            if (jellegSzerintLegregebbi == null)
            {
                Console.WriteLine("A megadott jellegű hajó nem létezik a cégnél!");
            }
            else
            {
                Console.WriteLine("\tA legöregebb hajó a megadott jellegűek között:");
                Console.WriteLine($"\tNév: {jellegSzerintLegregebbi.Nev}");
                Console.WriteLine($"\tTípus: {jellegSzerintLegregebbi.Tipus}");
                Console.WriteLine($"\tGyártási év: {jellegSzerintLegregebbi.GyartasiEv}");
                Console.WriteLine($"\tMaximális utaslétszám: {jellegSzerintLegregebbi.MaxUtas} fő");
                Console.WriteLine($"\tUtazó sebesség: {jellegSzerintLegregebbi.UtazoSebesseg} km/h");
            }

            (string tipus, int darab)[] tipusonkentiDarabszam = Logic.TipusonkentiDarabszam();
            Console.WriteLine("5. Igény: Típusonként a hajók száma:");
            foreach (var item in tipusonkentiDarabszam)
            {
                Console.WriteLine($"\t{item.tipus}: {item.darab} darab");
            }

            Console.WriteLine("6. Igény: Típusonként a legfiatalabb hajók:");
            var tipusonkentLegfiatalabb = Logic.TipusonkentLegfiatalabb();
            foreach (var item in tipusonkentLegfiatalabb)
            {
                if (item != null)
                {
                    Console.WriteLine($"\t{item.Tipus}: {item.Nev} ({item.GyartasiEv})");
                }
            }
        }
    }
}
