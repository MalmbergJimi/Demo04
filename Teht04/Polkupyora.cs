using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Polkupyora: Ajoneuvo
    {
        // LISÄTÄÄN POLKUPYÖRÄN UNIIKKEJA OMINAISUUKSIA
        public bool Vaihteet { get; set; }
        public string Vmallinimi { get; set; }
        

        public Polkupyora()
        {
        }

        public void TulostaTiedot()
        {
            int i = 1;
            Console.WriteLine("Polkupyörä" + i + " info:");
            Console.WriteLine("- Nimi: " + Nimi + ". Model: " + Malli + ". Vuosimalli: " + Vuosimalli +
                    ". Väri: " + Vari + ". Vaihteet: " + Vaihteet + ". Vaihteiden malli: " + Vmallinimi);
            i++;
        }

        /*
        // LISÄTÄÄN ToStringiin() POLKUPYÖRÄN OMINAISUUDET
        public override string ToString()
        {
            return base.ToString() + " " + Vaihteet + " " + Vmallinimi;
        } */
    }
}
