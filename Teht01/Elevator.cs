using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Elevator
    {
        private int MaxKerros = 5;
        private int MinKerros = 1;
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= MaxKerros && value >= MinKerros) floor = value;
                else
                {
                    Console.WriteLine("Ei mahdollinen kerros! Rakennuksessa on vain viisi kerrosta!");
                    floor = Floor;
                }
            }
        }
    }
}

