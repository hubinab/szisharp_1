using Data;
using Logic;

namespace CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolgozok Logic = new Dolgozok();
            using (StreamReader fileBe = new StreamReader("berek2020.txt"))
            {
                fileBe.ReadLine();
                string[] sorok = fileBe.ReadToEnd().Trim().Split('\n');
                foreach (var sor in sorok)
                {
                    string[] adatok = sor.Trim().Split(';');
                    Logic.AddDolgozo(new Dolgozo(adatok[0], adatok[1], adatok[2], int.Parse(adatok[3]), int.Parse(adatok[4])));
                }
            }

            Console.WriteLine($"6. feladat: Dolgozók száma: {Logic.SumDolgozok} fő");
            Console.WriteLine($"7. feladat: Bérek átlaga: {Logic.BerekAtlaga()} eFt");
            Console.WriteLine($"8. feladat: Részlegek: {string.Join(", ",Logic.Reszlegek())}");
            Console.Write("9. feladat: Kérem egy részleg nevét: ");
            string Reszleg = Console.ReadLine();
            Dolgozo? LegtobbetKereso = Logic.LegtobbetKeresoDolgozo(Reszleg);
            if (LegtobbetKereso != null)
            {
                Console.WriteLine("\tA legtöbbet kereső dolgozó a megadott részlegen:");
                Console.WriteLine($"\tNév: {LegtobbetKereso.Nev}");
                Console.WriteLine($"\tNeme: {LegtobbetKereso.Neme}");
                Console.WriteLine($"\tBelépés: {LegtobbetKereso.Belepes}");
                Console.WriteLine($"\tBér: {LegtobbetKereso.Ber} Ft");
            }
            else
            {
                Console.WriteLine("A megadott részleg nem létezik a cégnél!");
            }

            Console.WriteLine("10. feladat: Részlegenként a dolgozók száma:");
            var ReszlegenkentDolgozokSzama = Logic.ReszlegenkentDolgozokSzama();
            foreach (var reszleg in ReszlegenkentDolgozokSzama)
            {
                Console.WriteLine($"\t{reszleg.reszleg} - {reszleg.szam}");
            }
            Console.WriteLine("11. feladat: Részlegenként a legkisebb bérű dolgozó:");
            var ReszlegenkentLegkisebbFizu = Logic.ReszlegenkentLegkisebbFizu();
            foreach (var reszleg in ReszlegenkentLegkisebbFizu)
            {
                Console.WriteLine($"\t{reszleg.reszleg}: {reszleg.dolgozo.Nev} ({reszleg.dolgozo.Ber} Ft)");
            }
        }
    }
}
