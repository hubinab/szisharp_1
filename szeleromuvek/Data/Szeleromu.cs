namespace Data
{
    public class Szeleromu
    {
        public string Regio {  get; init; }
        public string Megye { get; init; }
        public string Telapules { get; init; }
        public int Darab {  get; init; }
        public int Teljesitmeny { get; init; }
        public int Ev {  get; init; }

        public Szeleromu(string regio, string megye, string telapules, int darab, int teljesitmeny, int ev)
        {
            Regio = regio;
            Megye = megye;
            Telapules = telapules;
            Darab = darab;
            Teljesitmeny = teljesitmeny;
            Ev = ev;
        }
    }
}
