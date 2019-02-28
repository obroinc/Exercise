using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Pages.Models
{
    public class Studentdb
    {


        [Required]
        [Display(Name = "First Name")]//Message diaplayed for user-lable
        
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "Last Name")]//Message diaplayed for user-lable

        public string LastName { get; set; } = "";

        [Required]
        [Display(Name = "StudentID")]//Message diaplayed for user-lable

        public string StudentID { get; set; } = "";


    }
}
