namespace Data
{
    public class Eredmeny
    {
        public string hazai {  get; init; }
        public string idegen { get; init; }
        public int hazaiPont { get; init; }
        public int idegenPont { get; init;}
        public string helyszin { get; init; }
        public DateOnly idopont { get; init; }

        public Eredmeny(string hazai, string idegen, int hazaiPont, int idegenPont, string helyszin, DateOnly idopont)
        {
            this.hazai = hazai;
            this.idegen = idegen;
            this.hazaiPont = hazaiPont;
            this.idegenPont = idegenPont;
            this.helyszin = helyszin;
            this.idopont = idopont;
        }
    }
}
