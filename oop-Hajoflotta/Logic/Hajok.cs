using Data;

namespace Logic
{
    public class Hajok
    {
        public List<Hajo> hajok;
        public int darab { get => hajok.Count; }
        public Hajok()
        {
            hajok = new List<Hajo>();
        }

        public void AddHajo(Hajo hajo)
        {
            hajok.Add(hajo);
        }
        public void AddHajo(string nev, string tipus, int gyartasiEv, int maxUtas, int etteremKapacitas, string jelleg, int utazoSebesseg)
        {
            hajok.Add(new Hajo(nev, tipus, gyartasiEv, maxUtas, etteremKapacitas, jelleg, utazoSebesseg));
        }

        public double FlottaEttermiKapacitasa()
        {
            return Math.Round(hajok.Average(x => x.EtteremKapacitas), 1);
        }

        public Hajo? JellegSzerintLegregebbi(string jelleg)
        {
            return hajok.Where(x => x.Jelleg == jelleg).MinBy(x => x.GyartasiEv);
        }

        public (string tipus, int darab)[] TipusonkentiDarabszam()
        {
            return hajok.GroupBy(x => x.Tipus).Select(x => (x.Key, x.Count())).ToArray();
        }
        public Hajo?[] TipusonkentLegfiatalabb()
        {
            return hajok.GroupBy(x => x.Tipus).Select(x => x.MaxBy(x => x.GyartasiEv)).ToArray();
        }
    }
}
