using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee arska = new Employee();
            arska.Names = "Arska Aapola";
            arska.Profession = "Tehdastyöläinen";
            arska.Salary = "1800e/kk";

            arska.PrintData();
            
            Boss pomo = new Boss();
            pomo.Names = "Teppo Teuvonen";
            pomo.Profession = "IT-ala";
            pomo.Salary = "5000e/kk";
            pomo.Car = "BMW M8";
            pomo.Bonus = "1000e";

            pomo.PrintDataBoss();            

            arska.Salary = "1500e/kk";
            arska.PrintData();
        }
    }
}
