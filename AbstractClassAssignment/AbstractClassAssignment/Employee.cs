using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person , IQuittable // "Employee" Class inherting from "Person" Class
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + " " + "hired." );
        }

        public string firstName { get; set; }
        public string lastName { get; set; }

        public void Quit()
        {
            Console.WriteLine(firstName + " " +  lastName + " " + "quits.");
        }
    }
}
