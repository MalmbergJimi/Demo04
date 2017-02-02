using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvari = new Vahvistin();
            vahvari.Volume = 0;

            Console.WriteLine("Anna vahvistimen äänenvoimakkuus (0-100): ");
            string line = Console.ReadLine();
            vahvari.Volume = int.Parse(line);

            Console.WriteLine("Äänenvoimakkuus on nyt: " + vahvari.Volume);
            Console.WriteLine();
        }
    }
}
