using Logic;

namespace Darts_statisztika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dobasok Logic = new Dobasok();

            using (StreamReader fileBe = new StreamReader("dobasok.txt"))
            {
                string[] sorok = fileBe.ReadToEnd().Trim().Split("\n");
                foreach (var sor in sorok)
                {
                    string[] egysor = sor.Trim().Split(";");
                    Logic.AddDobas(int.Parse(egysor[0]), egysor[1], egysor[2], egysor[3]);
                }
            }

            Console.WriteLine("2. feladat");
            Console.WriteLine($"Körök száma: {Logic.darab}");

            Console.WriteLine("3. feladat");
            Console.WriteLine($"3. dobásra Bullseye: {Logic.HarmadikDobasraBullsEye()}");

            Console.WriteLine("4. feladat");
            Console.Write("Adja meg a szektor értékét! Szektor = ");
            string Szektor = Console.ReadLine();
            Console.WriteLine($"Az 1. játékos a(z) {Szektor} szektoros dobásainak száma: {Logic.SzektorDobasokSzama(1, Szektor)}");
            Console.WriteLine($"A 2. játékos a(z) {Szektor} szektoros dobásainak száma: {Logic.SzektorDobasokSzama(2, Szektor)}");

            Console.WriteLine("5. feladat");
            Console.WriteLine($"Az 1. játékos {Logic.T20DobasokSzama(1)} db 180-ast dobott.");
            Console.WriteLine($"A 2. játékos {Logic.T20DobasokSzama(2)} db 180-ast dobott.");
        }
    }
}
