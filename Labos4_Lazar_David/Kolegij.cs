using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labos4_Lazar_David
{
    class Kolegij
    {
        public static List<Kolegij> SviKolegiji = new List<Kolegij>();


        public int ProsjecnaOcjena { get; set; }
        public string NazivKolegija { get; set; }
        public List<int> Ocjena = new List<int>();

        public Kolegij(string naziv, int ocjena)
        {
            NazivKolegija = naziv;
            ProsjecnaOcjena = ocjena;
            SviKolegiji.Add(this);
        }
        public static decimal ProsjecnaOcjenaKolegija(List<int> ocjena)
        {
            decimal prosjecnaOcjena = 0;
            int zbroj = 0;
            int brojac = 0;
            foreach (var item in ocjena)
            {
                zbroj = item;
            }
            return zbroj;
        }

        public static bool ProvjeraNaziva(string naziv)
        {
            foreach (var item in SviKolegiji)
            {
                if (naziv == item.NazivKolegija) return true;
            }
            return false;
        }
    }
}
