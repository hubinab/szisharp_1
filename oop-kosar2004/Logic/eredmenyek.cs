using Data;

namespace Logic
{
    public class Eredmenyek
    {
        public List<Eredmeny> eredmenyek;

        public Eredmenyek()
        { 
            eredmenyek = new List<Eredmeny>();
        }

        public void AddEredmeny(string hazai, string idegen, int hazaiPont, int idegenPont, string helyszin, DateOnly idopont)
        {
            eredmenyek.Add(new Eredmeny(hazai, idegen, hazaiPont, idegenPont, helyszin, idopont));
        }

        public (int hazai, int idegen) HazaiEsIdegenMerkozesekSzama(string csapatNeve)
        {
            int hazai = eredmenyek.Where(x => x.hazai==csapatNeve).Count();
            int idegen = eredmenyek.Where(x => x.idegen == csapatNeve).Count();
            return (hazai, idegen);
        }

        public int DontetlenMerkozesekSzama()
        {
            return eredmenyek.Where(x => x.idegenPont==x.hazaiPont).Count();
        }

        public string? VarosNeveSzerepelEACsapatNEveben(string varosNeve)
        {
            return eredmenyek.Where(x => x.hazai.ToUpper().Contains(varosNeve.ToUpper())).Select(x => x.hazai).FirstOrDefault();
        }
        public Eredmeny[] HazaiMerkozesen100PontFelett()
        {
            return eredmenyek.Where(x => x.hazaiPont > 100).OrderBy(x => (x.idopont, x.hazai)).ToArray();
        }
        public Eredmeny[] AdottIdopontbanMelyCsapatokJatszottak(DateOnly idopont)
        {
            return eredmenyek.Where(x => x.idopont == idopont).ToArray();
        }

        public Eredmeny LegnagyobbPontKulonbseguMerkozes()
        {
            return eredmenyek.OrderByDescending(x => Math.Abs(x.idegenPont - x.hazaiPont)).First();
        }
        
        public (string Stadion, int MerkozesekSzama)[] StadionokAhol20TobbMerkozestJatszottak()
        {
            return eredmenyek.GroupBy(x => x.helyszin).Select(x => (x.Key, x.Count())).Where(x => x.Item2 > 20).ToArray();
        }
    }
}
