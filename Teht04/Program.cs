using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            // LUODAAN POLKUPYÖRÄ
            Polkupyora tsyga = new Polkupyora();
            tsyga.Nimi = "Ori";
            tsyga.Malli = "Poni";
            tsyga.Vuosimalli = 2016;
            tsyga.Vari = "Keltainen";
            tsyga.Vaihteet = true;
            tsyga.Vmallinimi = "Shimano RX";
            //TULOSTETAAN TIEDOT
            tsyga.TulostaTiedot();

            // LUODAAN POLKUPYÖRÄ2
            Polkupyora mankeli = new Polkupyora();
            mankeli.Nimi = "Yolo";
            mankeli.Malli = "Yopo";
            mankeli.Vuosimalli = 2000;
            mankeli.Vari = "Punainen";
            mankeli.Vaihteet = false;
            mankeli.Vmallinimi = "";
            //TULOSTETAAN TIEDOT
            mankeli.TulostaTiedot();
            

            //LUODAAN VENE
            Vene boten = new Vene();
            boten.Nimi = "Titanic";
            boten.Malli = "Uppoomaton";
            boten.Vuosimalli = 1912;
            boten.Vari = "Valkoinen";
            boten.Vtyyppi = "Puolikas";
            boten.Istuimet = 200;
            //TULOSTETAAN TIEDOT
            boten.TulostaTiedot(); 
                      
            //LUODAAN VENE2
            Vene vene = new Vene();
            vene.Nimi = "M/S Lippulaiva";
            vene.Malli = "Lipullinen";
            vene.Vuosimalli = 1800;
            vene.Vari = "Ruskea";
            vene.Vtyyppi = "Yksimastoinen";
            vene.Istuimet = 3;
            //TULOSTETAAN TIEDOT
            vene.TulostaTiedot();

        }
    }
}
