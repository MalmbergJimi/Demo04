using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vene : Ajoneuvo
    {
        // Lisätään Veneen ominaisuudet
        public string Vtyyppi { get; set; }
        public int Istuimet { get; set; }

        public Vene()
        {
        }

        public void TulostaTiedot()
        {
            int i=1;
            Console.WriteLine("Veneen" + i + " info:");
            Console.WriteLine("- Nimi: " + Nimi + ". Model: " + Malli + ". Vuosimalli: " + Vuosimalli +
                    ". Väri: " + Vari + ". Veneen tyyppi: " + Vtyyppi + ". Istuimien lukumäärä: " + Istuimet);
            i++;
        }

        /*
        // LISÄTÄÄN ToStringiin() Veneen OMINAISUUDET
        public override string ToString()
        {
            return base.ToString() + " " + Vtyyppi + " " + Istuimet;
        } */
    }
}
