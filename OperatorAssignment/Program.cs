using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 100, FirstName = "Monzur", LastName = "Siddique" };

            Employee employee2 = new Employee() { Id = 999, FirstName = "William", LastName = "Gates"};

            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("Both employees'identifications are the same.");
            }
            else
            {
                Console.WriteLine("Both employees' identifications are not the same.");

            }

            Console.ReadLine();
        }

    }
}
