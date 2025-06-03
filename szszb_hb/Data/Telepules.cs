namespace Data
{
    public class Telepules
    {
        public string telepules { get; init; }
        public string rang {  get; init; }
        public string terseg {  get; init; }
        public int terulet { get; init; }
        public int lakossag { get; init; }

        public Telepules(string telepules, string rang, string terseg, int terulet, int lakossag)
        {
            this.telepules = telepules;
            this.rang = rang;
            this.terseg = terseg;
            this.terulet = terulet;
            this.lakossag = lakossag;
        }

    }
}
