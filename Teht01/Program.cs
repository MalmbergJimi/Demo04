using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();
            hissi.Floor = 1;
            int i = 0;

            
                Console.WriteLine("Olet kerroksessa " + hissi.Floor);
            do
            {
                Console.WriteLine("Mihin kerrokseen haluat mennä? ");
                string line = Console.ReadLine();
                hissi.Floor = int.Parse(line);

                Console.WriteLine("Olet kerroksessa " + hissi.Floor);
                i++;

            } while (i < 5);

        }
    }
}
