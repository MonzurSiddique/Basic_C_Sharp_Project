using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee() { firstName = "William", lastName = "Gates" }; // Instantiating the Employee object

            emp.SayName(); //Call the method on the object

            List<IQuittable> quits = new List<IQuittable>();

            Employee emp1 = new Employee();
            quits.Add(emp);

            foreach (IQuittable quit in quits)
            {
                quit.Quit();
            }

            Console.ReadLine();
        }
    }
}
