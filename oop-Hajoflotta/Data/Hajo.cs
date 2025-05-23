namespace Data
{
    public class Hajo
    {
        public string Nev { get; init; }
        public string Tipus { get; init; }
        public int GyartasiEv { get; init; }
        public int MaxUtas { get; init; }
        public int EtteremKapacitas { get; init; }
        public string Jelleg { get; init; }
        public int UtazoSebesseg { get; init; }

        public Hajo(string nev, string tipus, int gyartasiEv, int maxUtas, int etteremKapacitas, string jelleg, int utazoSebesseg)
        {
            Nev = nev;
            Tipus = tipus;
            GyartasiEv = gyartasiEv;
            MaxUtas = maxUtas;
            EtteremKapacitas = etteremKapacitas;
            Jelleg = jelleg;
            UtazoSebesseg = utazoSebesseg;
        }
    }
}
