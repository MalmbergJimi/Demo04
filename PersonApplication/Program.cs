using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create one teacher from Teacher class
            Teacher ope = new Teacher();
            ope.FirstName = "Hissi";
            ope.LastName = "Hilleri";
            ope.Address = "Valtukunnankatu 15";
            ope.Age = 55;
            ope.PhoneNumber = "010-5557771";
            ope.Room = "229";
            Console.WriteLine(ope.ToString());

            // Create one Student from Student class
            Student oppilas = new Student("Kalle", "Kakkahousu", "K4KK4");
            oppilas.Address = "Housunkuja 2";
            oppilas.Age = 3;
            oppilas.PhoneNumber = "444-44444444";
            Console.WriteLine(oppilas.ToString());

            ope.TeacherMethod();
            oppilas.StudentMethod();


        }
    }
}
