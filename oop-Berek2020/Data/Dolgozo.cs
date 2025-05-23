namespace Data
{
    public class Dolgozo
    {
        public string Nev { get; init; }
        public string Neme { get; init; }
        public string Reszleg { get; init; }
        public int Belepes { get; init; }
        public int Ber {  get; init; }
        public Dolgozo(string nev, string neme, string reszleg, int belepes, int ber)
        {
            Nev = nev;
            Neme = neme;
            Reszleg = reszleg;
            Belepes = belepes;
            Ber = ber;
        }
    }
}
