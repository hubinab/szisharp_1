using System.Globalization;
using Data;
using Logic;

namespace kosar2004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eredmenyek Logic = new Eredmenyek();
            using (StreamReader fileBe = new StreamReader("eredmenyek.csv")) 
            {
                fileBe.ReadLine();
                string[] sorok = fileBe.ReadToEnd().Trim().Split('\n');
                foreach (var sor in sorok)
                {
                    string[] egySor = sor.Trim().Split(";");
                    Logic.AddEredmeny(egySor[0], egySor[1], int.Parse(egySor[2]), int.Parse(egySor[3]), egySor[4], DateOnly.Parse(egySor[5]));
                }
            }

            Console.Write("4. feladat: Csapat neve: ");
            string CsapatNeve = Console.ReadLine();
            (int hazai, int idegen) = Logic.HazaiEsIdegenMerkozesekSzama(CsapatNeve);
            Console.WriteLine($"\tHazai mérkőzések száma: {hazai}");
            Console.WriteLine($"\tIdegen mérkőzések száma: {idegen}");

            Console.Write("5.feladat: ");
            int DontetlenMerkozesekSzama = Logic.DontetlenMerkozesekSzama();
            if (DontetlenMerkozesekSzama > 0)
            {
                Console.WriteLine($"Összesen {DontetlenMerkozesekSzama} döntetlen mérkőzés volt.");
            }
            else
            {
                Console.WriteLine("Nem volt döntetlen mérkőzés.");
            }

            Console.Write("6. feladat: A város neve: ");
            string Varos = Console.ReadLine();
            var VarosiCsapatNeve = Logic.VarosNeveSzerepelEACsapatNEveben(Varos);
            if (VarosiCsapatNeve == null)
            {
                Console.WriteLine("\tNincs ilyen város nevet tartalmazo csapat.");
            }
            else
            {
                Console.WriteLine($"\tA csapat neve: {VarosiCsapatNeve}");
            }

            Console.WriteLine("7. feladat: 100 pont felett dobtak hazai meccsen:");
            Eredmeny[] hazaiCsapat100PontFelett = Logic.HazaiMerkozesen100PontFelett();
            foreach (var item in hazaiCsapat100PontFelett)
            {
                Console.WriteLine($"\t{item.idopont.ToString(new CultureInfo("hu-hu"))}: {item.hazai} - {item.idegen} ({item.hazaiPont}:{item.idegenPont})");
            }

            Console.Write("8. feladat: Az időpont (pl.: 2004.11.21): ");
            DateOnly IdoPont;
            string SIdoPont = Console.ReadLine();
            if (SIdoPont == null || !DateOnly.TryParse(SIdoPont, out IdoPont))
            {
                Console.WriteLine("\tNem megfelelő dátumformátum.");
            }
            else
            {
                Eredmeny[] MelyCsapatokJatszottak = Logic.AdottIdopontbanMelyCsapatokJatszottak(IdoPont);
                foreach (var item in MelyCsapatokJatszottak)
                {
                    Console.WriteLine($"\t{item.hazai} - {item.idegen} ({item.hazaiPont}:{item.idegenPont})");
                }
            }

            var LegnagyobbPontKulonbseguMerkozes = Logic.LegnagyobbPontKulonbseguMerkozes();
            Console.WriteLine("9. feladat: A legnagyobb pontkülönbségű mérkőzés adatai:");
            Console.WriteLine($"\t{LegnagyobbPontKulonbseguMerkozes.idopont.ToString(new CultureInfo("hu-hu"))}: {LegnagyobbPontKulonbseguMerkozes.hazai} - {LegnagyobbPontKulonbseguMerkozes.idegen} ({LegnagyobbPontKulonbseguMerkozes.hazaiPont}:{LegnagyobbPontKulonbseguMerkozes.idegenPont})");

            Console.WriteLine("10. feladat: Stadionok, ahol 20-nál több mérkőzést játszottak:");
            (string Stadion, int Merkozesek)[] MerkozesekSzamaStadiononkent = Logic.StadionokAhol20TobbMerkozestJatszottak();
            foreach (var item in MerkozesekSzamaStadiononkent)
            {
                Console.WriteLine($"\t{item.Stadion}: {item.Merkozesek}");
            }
        }
    }
}
