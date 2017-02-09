using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Ajoneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Vari { get; set; }

        public Ajoneuvo()
        {
        }

        public Ajoneuvo(string nimi)
        {
            Nimi = nimi;
        }
       

        
    }
}
