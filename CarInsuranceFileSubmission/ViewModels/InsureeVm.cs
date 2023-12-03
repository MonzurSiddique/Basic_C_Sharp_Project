using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class InsureeVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal  Quote { get; set; }
        public DateTime DateOfBirth { get; internal set; }
        public int CarYear { get; internal set; }
        public string CarMake { get; internal set; }
        public string CarModel { get; internal set; }
        public bool DUI { get; internal set; }
        public int SpeedingTickets { get; internal set; }
        public bool CoverageType { get; internal set; }
    }
}