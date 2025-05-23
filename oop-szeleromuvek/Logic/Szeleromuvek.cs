using Data;

namespace Logic
{
    public class Szeleromuvek
    {
        public List<Szeleromu> szeleromuvek;

        public Szeleromuvek()
        {
            szeleromuvek = new List<Szeleromu>();
        }

        public void AddSzeleromu(Szeleromu szeleromu) 
        { 
            szeleromuvek.Add(szeleromu);
        }

        public void AddSzeleromu(string regio, string telepules, string megye, int darab, int teljesitmeny, int ev) 
        {
            szeleromuvek.Add(new Szeleromu(regio, telepules, megye, darab, teljesitmeny, ev));
        }

        public (string regio, int darab)[] RegionkentiSzeleromuvek()
        {
            return szeleromuvek.GroupBy(x => x.Regio).Select(x => (x.Key, x.Count())).ToArray();
        }

        public string? LegtobbTelepitesuRegio()
        {
            // Copilot:
            return szeleromuvek.GroupBy(x => x.Regio).Select(x => (x.Key, x.Count())).OrderByDescending(x => x.Item2).First().Key;
        }

        public (string regio, int darab)[] RegionkentiSzeleromuvekDB()
        {
            return szeleromuvek.GroupBy(x => x.Regio).Select(x => (x.Key, x.Sum(y => y.Darab))).ToArray();
        }
        public (string regio, string megye, int darab)[] RegionkentMegyenkentSzeleromuvekDB()
        {
            return szeleromuvek.GroupBy(x => (x.Regio, x.Megye)).Select(x => (x.Key.Regio, x.Key.Megye, x.Sum(y => y.Darab))).ToArray();
        }
        public (string telepules, int darab)[] TelepulesenkentiSzeleromuvekDB()
        {
            return szeleromuvek.GroupBy(x => x.Telapules).Select(x => (x.Key, x.Sum(y => y.Darab))).Where(x => x.Item2 >= 10).ToArray();
        }
        public (string telepules, int darab)[] TelepulesenkentiSzeleromuvekDBMax3()
        {
            return szeleromuvek.GroupBy(x => x.Telapules).Select(x => (x.Key, x.Sum(y => y.Darab))).OrderByDescending(x => x.Item2).Take(3).ToArray();
        }
        public (string telepules, double teljesitmeny)[] TelepulesenkentiAtlagosKWMin1500()
        {
            return szeleromuvek.GroupBy(x => x.Telapules).Select(x => (x.Key, x.Average(y => y.Teljesitmeny))).Where(x => x.Item2 > 1500).ToArray();
        }
        public (string telepules, int teljesitmeny)[] TelepulesenkentiOsszteljesitmenyMax5()
        {
            return szeleromuvek.GroupBy(x => x.Telapules).Select(x => (x.Key, x.Sum(y => y.Teljesitmeny*y.Darab))).OrderByDescending(x => x.Item2).Take(5).Order().ToArray();
        }
    }
}
