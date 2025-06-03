using Data;
using Logic;

namespace CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telepulesek Logic = new Telepulesek();
            using(StreamReader fileBe = new StreamReader("szszb.csv"))
            {
                fileBe.ReadLine();
                string[] sorok = fileBe.ReadToEnd().Trim().Split('\n');
                foreach (var sor in sorok)
                {
                    string[] egySor = sor.Trim().Split(";");
                    Logic.addTelepules(egySor[0], egySor[1], egySor[2], int.Parse(egySor[3]), int.Parse(egySor[4]));
                }
            }
            Console.WriteLine($"3. feladat: Települések száma {Logic.telepulesekSzama} db");
            Console.WriteLine($"4. feladat: Települések átlagos mérete: {Logic.telepulesekAtlagosMerete()} ha");
            Console.WriteLine($"5. feladat: Térségek: {string.Join(", ", Logic.tersegekNevei())}");
            Console.Write("6. feladat: Kérem a térség nevét: ");
            string tersegBe = Console.ReadLine();
            var legnagyobbNepsuruseguTelepules = Logic.LegnagyobbNepsuruseguTelepules(tersegBe);
            if (legnagyobbNepsuruseguTelepules != null)
            {
                Console.WriteLine("\tA legnagyobb népsűrűségű település adatai a térségben:");
                Console.WriteLine($"\tTelepülésnév: {legnagyobbNepsuruseguTelepules.telepules}");
                Console.WriteLine($"\tRang: {legnagyobbNepsuruseguTelepules.rang}");
                Console.WriteLine($"\tNépsűrűség: {legnagyobbNepsuruseguTelepules.lakossag / (legnagyobbNepsuruseguTelepules.terulet / 100.0):F2} Fő/km2");
            }
            else
            {
                Console.WriteLine("\tA megadott térség nem létezik!");
            }
            (string rang, int telepulesekSzama)[] rangonkentTelepulesekSzama = Logic.rangonkentTelepulesekSzama();
            Console.WriteLine("7. feladat: Település rangonként a települések száma:");
            foreach (var item in rangonkentTelepulesekSzama)
            {
                Console.WriteLine($"\t{item.rang}: {item.telepulesekSzama}");
            }
            (string rang, double telepulesekSzama)[] rangonkentLakossagSzama = Logic.rangonkentLakossagSzama();
            Console.WriteLine("8. feladat: Település rangonként a lakosok száma:");
            foreach (var item in rangonkentLakossagSzama)
            {
                Console.WriteLine($"\t{item.rang}: {item.telepulesekSzama} ezer fő");
            }
        }
    }
}
