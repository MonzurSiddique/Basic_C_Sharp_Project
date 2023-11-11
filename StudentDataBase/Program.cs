using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Monzur Siddique" };

                ctx.Students.Add(stud);
                
                ctx.SaveChanges();

            }

        }
    }
}
