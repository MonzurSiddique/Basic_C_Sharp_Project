using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBase
{
    class SchoolContext: DbContext
    {
        public SchoolContext(): base("SchoolDBConnectionString")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
