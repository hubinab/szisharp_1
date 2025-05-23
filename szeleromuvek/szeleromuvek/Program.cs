using Logic;
using System.Reflection.Metadata;

namespace szeleromuvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szeleromuvek Logic = new Szeleromuvek();

            using (StreamReader fileBe = new StreamReader("szeleromuvek.csv"))
            {
                fileBe.ReadLine();
                string[] sorok = fileBe.ReadToEnd().Trim().Split("\n");
                foreach (var sor in sorok) 
                {
                    string[] egySor = sor.Trim().Split(";");
                    Logic.AddSzeleromu(egySor[0], egySor[1], egySor[2], int.Parse(egySor[3]), int.Parse(egySor[4]), int.Parse(egySor[5]));
                }
            }

            Console.WriteLine("2. feladat:");
            Console.WriteLine("Régiónként a szélerőmű telepítések száma:");
            (string regio, int darab)[] regionkentiszeleromuvek = Logic.RegionkentiSzeleromuvek();
            foreach (var regio in regionkentiszeleromuvek)
            {
                Console.WriteLine($"{regio.regio}: {regio.darab} db helyszín");
            }
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"{Logic.LegtobbTelepitesuRegio()} régióban volt a legtöbbször szélerőmű telepítés.");
            Console.WriteLine("4. feladat:");
            Console.WriteLine("Régiónként a szélerőművek száma:");
            (string regio, int darab)[] regionkentiszeleromuvekDB = Logic.RegionkentiSzeleromuvekDB();
            foreach (var regio in regionkentiszeleromuvekDB)
            {
                Console.WriteLine($"{regio.regio}: {regio.darab} db szélerőmű");
            }
            Console.WriteLine("5. feladat:");
            Console.WriteLine("Az egyes régiókban megyénként telepített szélerőművek száma:");
            (string regio, string megye, int darab)[] regionkentmegye = Logic.RegionkentMegyenkentSzeleromuvekDB();
            foreach (var regio in regionkentmegye)
            {
                Console.WriteLine($"{regio.regio} - {regio.megye}: {regio.darab} db szélerőmű");
            }
            Console.WriteLine("6. feladat:");
            Console.WriteLine("Településenként a szélerőművek száma:");
            (string telepules, int darab)[] telepulesenkentiszeleromuvekDB = Logic.TelepulesenkentiSzeleromuvekDB();
            foreach (var telepules in telepulesenkentiszeleromuvekDB)
            {
                Console.WriteLine($"{telepules.telepules}: {telepules.darab}");
            }
            Console.WriteLine("7. feladat:");
            Console.WriteLine("A 3 legtöbb szélerőművet tartalmazó település:");
            (string telepules, int darab)[] telepulesenkentiszeleromuvekDBMax3 = Logic.TelepulesenkentiSzeleromuvekDBMax3();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{telepulesenkentiszeleromuvekDBMax3[i].telepules}: {telepulesenkentiszeleromuvekDBMax3[i].darab}");
            }
            Console.WriteLine("8. feladat:");
            Console.WriteLine("A szélerőművek átlagos teljesítménye településenként:");
            (string telepules, double teljesitmeny)[] telepulesenkentiatlagosKWMin1500 = Logic.TelepulesenkentiAtlagosKWMin1500();
            foreach (var telepules in telepulesenkentiatlagosKWMin1500)
            {
                Console.WriteLine($"{telepules.telepules}: {telepules.teljesitmeny:F1} kW");
            }
            Console.WriteLine("9. feladat:");
            Console.WriteLine("Az 5 legnagyobb összteljesítményű szélerőművekkel rendelkező település:");
            (string telepules, int teljesitmeny)[] telepulesenkentiosszteljesitmenyMax5 = Logic.TelepulesenkentiOsszteljesitmenyMax5();
            foreach (var item in telepulesenkentiosszteljesitmenyMax5)
            {
                Console.WriteLine($"{item.telepules} településen az összteljesítmény: {item.teljesitmeny} kW");
            }
        }
    }
}
