﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public interface IQuittable
    {
        void Quit();

        string firstName { get; set; }
        string lastName { get; set; }
           
    }
}
