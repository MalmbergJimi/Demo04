using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public string Bonus { get; set; }

        public Boss()
        {
        }

        public void PrintDataBoss()
        {

            Console.WriteLine("Employee:");
            Console.WriteLine("- Names: " + Names + ". Profession: " + Profession + ". Palkka: " + Salary +
                ". Auto: " + Car + ". Bonus: " + Bonus);

        }

        public override string ToString()
        {
            return base.ToString() + " " + Car + " " + Bonus;
        }
    }
}
