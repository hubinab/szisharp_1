using Data;

namespace Logic
{
    public class Telepulesek
    {
        public List<Telepules> telepulesek;
        public int telepulesekSzama => telepulesek.Count;

        public Telepulesek()
        { 
            telepulesek = new List<Telepules>();
        }

        public void addTelepules(Telepules telepules)
        {
            telepulesek.Add(telepules);
        }
        public void addTelepules(string telepules, string rang, string terseg, int terulet, int lakossag)
        {
            telepulesek.Add(new Telepules(telepules, rang, terseg, terulet, lakossag));
        }

        public double telepulesekAtlagosMerete()
        {
            return Math.Round(telepulesek.Average(x => x.terulet), 1);
        }
        public string[] tersegekNevei()
        {
            return telepulesek.Select(x => x.terseg).Distinct().Order().ToArray();
        }
        public (string rang, int telepulesekSzama)[] rangonkentTelepulesekSzama() 
        { 
            return telepulesek.GroupBy(x => x.rang).Select(x => (x.Key, x.Count())).ToArray(); 
        }
        public Telepules? LegnagyobbNepsuruseguTelepules (string terseg)
        {
            return telepulesek.Where(x => x.terseg.ToLower() == terseg.ToLower()).MaxBy(x => (x.lakossag/(x.terulet/100.0)));
        }
        public (string rang, double telepulesekSzama)[] rangonkentLakossagSzama()
        {
            return telepulesek.GroupBy(x => x.rang).Select(x => (x.Key, Math.Round(x.Sum(x => x.lakossag) / 1000.0, 1))).ToArray();
        }
    }
}
