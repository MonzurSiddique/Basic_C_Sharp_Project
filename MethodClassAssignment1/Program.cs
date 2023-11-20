using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.AddTwoIntegers(14, 14);
            Console.WriteLine(calculation.y);
            Console.ReadLine();
        }
    }
}
