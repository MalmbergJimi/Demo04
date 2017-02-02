using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Employee
    {
        public string Names { get; set; }
        public string Profession { get; set; }
        public string Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string names)
        {
            Names = names;
        }

        // methods

       
        public override string ToString()
        {
            return Names + " " + Profession + " " + Salary;
        }
    }
}
