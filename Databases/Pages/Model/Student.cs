using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Databases.Pages.Model
{
    public class Student
    {
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name ="Second Name")]
        public string LastName { get; set; } = "";

        [Required]
        [Display(Name ="Student ID")]
        public string StudentID { get; set; } = "";
    }
}
