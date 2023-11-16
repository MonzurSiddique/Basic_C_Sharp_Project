using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation(10, 12); //Instantiating the class
            int num1 = Math.Max(10, 12); //Calling the built-in Math-function method and specifying the parameters
            int num2 = 12;

            Console.WriteLine("Maximum and second number are: {0},{1}", num1, num2);
            Console.ReadLine();
        }
       
    }
}
