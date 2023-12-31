﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
          if (employee1.Id.Equals(employee2.Id))
          {
              return false;
          }
            return true;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }

    }
}
