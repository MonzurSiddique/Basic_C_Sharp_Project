using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace StudentDB.Models
{
    public class CsharpStudentDBContext : DbContext
    {
        public CsharpStudentDBContext() : base("CsharpConnection")
        {

        }
        public DbSet<StudentList> StudentList { get; set; }
    }
}