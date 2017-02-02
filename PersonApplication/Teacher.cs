using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to the TEACHEER!");
        }

        public override string ToString()
        {
            // Base on tässä tapauksessa "Person"-luokka
            // Eli kutsutaan Person-luokan ToString()-metodia
            // return FirstName + " " + LastName + " " ... + Room;
            return base.ToString() + " " + Room;
        }

    }
}
