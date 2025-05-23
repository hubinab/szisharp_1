using Data;

namespace Logic
{
    public class Dolgozok
    {
        List<Dolgozo> dolgozok;

        public int SumDolgozok => dolgozok.Count; 
        public Dolgozok()
        {
            dolgozok = new List<Dolgozo>();
        }
        public void AddDolgozo(Dolgozo dolgozo)
        {
            dolgozok.Add(dolgozo);
        }

        public void AddDolgozo(string nev, string neme, string reszleg, int belepes, int ber)
        {
            dolgozok.Add(new Dolgozo(nev, neme, reszleg, belepes, ber));
        }

        public double BerekAtlaga()
        {
            return double.Round(dolgozok.Average(dolgozo => dolgozo.Ber) / 1000, 1);
        }

        public string [] Reszlegek()
        {
            return dolgozok.Select(dolgozo => dolgozo.Reszleg).Distinct().Order().ToArray();
        }

        public Dolgozo? LegtobbetKeresoDolgozo(string reszleg)
        {
            return dolgozok.Where(dolgozo => dolgozo.Reszleg == reszleg).MaxBy(dolgozo => dolgozo.Ber * (2020-dolgozo.Belepes) * 12);
        }

        public (string reszleg, int szam)[] ReszlegenkentDolgozokSzama()
        {
            return dolgozok.GroupBy(dolgozo => dolgozo.Reszleg).Select(x => (x.Key, x.Count())).Order().ToArray();
        }

        public (string reszleg, Dolgozo dolgozo)[] ReszlegenkentLegkisebbFizu()
        {
            return dolgozok.GroupBy(dolgozo => dolgozo.Reszleg).Select(x => (x.Key, x.MinBy(dolgozo => dolgozo.Ber))).Order().ToArray();
        }

    }
}
