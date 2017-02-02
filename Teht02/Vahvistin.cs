using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Vahvistin
    {
        private int MaxVolume = 100;
        private int MinVolume = 0;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= MaxVolume && value >= MinVolume) volume = value;
                else if(value <= MinVolume)
                {
                    Volume = 0;
                    volume = Volume;
                    Console.WriteLine("Ei mahdollinen arvo! Aseta arvo välille 0-100.");
                }
                else
                {
                    Volume = 100;
                    volume = Volume;
                    Console.WriteLine("Ei mahdollinen arvo! Aseta arvo välille 0-100.");
                }
            }
        }
    }
}
