using System.Security.Cryptography.X509Certificates;

namespace Data
{
    public class Dobas
    {
        public int jatekos {  get; init; }
        public string elso { get; init; }
        public string masodik {  get; init; }
        public string harmadik { get; init; }

        public Dobas(int jatekos, string elso, string masodik, string harmadik)
        {
            this.jatekos = jatekos;
            this.elso = elso;
            this.masodik = masodik;
            this.harmadik = harmadik;
        }
    }
}
