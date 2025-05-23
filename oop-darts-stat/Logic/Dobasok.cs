using Data;

namespace Logic
{
    public class Dobasok
    {
        public List<Dobas> dobasok;
        public int darab { get => dobasok.Count; }

        public Dobasok()
        {
            dobasok = new List<Dobas>();
        }

        public void AddDobas(Dobas dobas)
        {
            dobasok.Add(dobas);
        }
        public void AddDobas(int jatekos, string elso, string masodik, string harmadik)
        {
            dobasok.Add(new Dobas(jatekos, elso, masodik, harmadik));
        }

        public int HarmadikDobasraBullsEye()
        {
            return dobasok.Where(x => x.harmadik == "D25").Count();
        }

        public int SzektorDobasokSzama(int jatekos, string szektor)
        {
            return dobasok.Where(x => (x.elso == szektor || x.masodik == szektor || x.harmadik == szektor) && x.jatekos == jatekos).Count(); ;
        }
        public int T20DobasokSzama(int jatekos)
        {
            return dobasok.Where(x => (x.elso == "T20" && x.masodik == "T20" && x.harmadik == "T20") && x.jatekos == jatekos).Count(); ;
        }
    }
}
