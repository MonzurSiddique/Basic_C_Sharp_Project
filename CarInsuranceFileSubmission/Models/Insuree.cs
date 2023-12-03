//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Insuree
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Date of Birth")]
        public System.DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Car Year")]
        public int CarYear { get ; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool DUI { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Speeding Tickets")]
        public int SpeedingTickets { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Coverage Type")]
        public bool CoverageType { get; set; }

        [Required(ErrorMessage = "Required")]
     
        public decimal Quote { get; set; }
    }
}