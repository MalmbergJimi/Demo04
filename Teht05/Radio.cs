using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Radio
    {
        private int maxvolume = 100;
        private int minvolume = 0;
        private double maxtaajuus = 26000.0;
        private double mintaajuus = 2000.0;
        private int volume;
        private double taajuus;
        public bool IsOn { get; set; }
            
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxvolume && value >= minvolume) volume = value;
                else if (value <= minvolume)
                {
                    Volume = 0;
                    volume = Volume;
                    Console.WriteLine("** Ei mahdollinen arvo! Aseta arvo välille 0-100. **");
                }
                else
                {
                    Volume = 100;
                    volume = Volume;
                    Console.WriteLine("** Ei mahdollinen arvo! Aseta arvo välille 0-100. **");

                }
            }
        }
        public double Taajuus
        {
            get
            {
                return taajuus;
            }
            set
            {
                if (value <= maxtaajuus && value >= mintaajuus) taajuus = value;
                else if (value <= mintaajuus)
                {
                    Taajuus = 2000.0;
                    taajuus = Taajuus;
                    Console.WriteLine("** Valittu taajuus liian pieni. Asetettu taajuudelle 2000.0 **");
                    Console.WriteLine("** Taajuudet valittavissa väliltä 2000.0 - 26000.0 **");
                    
                }
                else
                {
                    Taajuus = 26000.0;
                    taajuus = Taajuus;
                    Console.WriteLine("** Valittu taajuus liian suuri. Asetettu taajuudelle 26000.0 **");
                    Console.WriteLine("** Taajuudet valittavissa väliltä 2000.0 - 26000.0 **");
                    
                }
            }

        }

        public void PrintData()
        {
            Console.WriteLine("Onko Radio päällä?: " + IsOn);
            Console.WriteLine("Äänenvoimakkuus on: " + Volume);
            Console.WriteLine("Taajuus on: " + Taajuus);
            Console.WriteLine();
        }
    }
}
