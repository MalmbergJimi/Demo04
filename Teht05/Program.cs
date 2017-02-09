using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan Radio ratio
            Radio ratio = new Radio();
            ratio.IsOn = true;
            ratio.Volume = 1;
            ratio.Taajuus = 1500.0;

            ratio.PrintData();

            //Luodaan Radio aalto
            Radio aalto = new Radio();
            aalto.IsOn = true;
            aalto.Volume = 55;
            aalto.Taajuus = 25000.5;

            aalto.PrintData();

            //Luodaan Radio puhe
            Radio puhe = new Radio();
            puhe.IsOn = true;
            puhe.Volume = 89;
            puhe.Taajuus = 1900.0;

            puhe.PrintData();

            //Luodaan Radio puhe
            Radio poop = new Radio();
            poop.IsOn = true;
            poop.Volume = -5;
            poop.Taajuus = 27000.0;

            poop.PrintData();



            /*
            do
            {
                Console.WriteLine("Anna Radion äänenvoimakkuus (0-100): ");
                string line = Console.ReadLine();
                ratio.Volume = int.Parse(line);

                Console.WriteLine("Äänenvoimakkuus on nyt: " + ratio.Volume);
                Console.WriteLine();
                i++;
            } while (i < 5); */
        }
    }
}
