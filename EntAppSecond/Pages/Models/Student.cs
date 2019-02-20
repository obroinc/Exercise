using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntAppSecond.Pages.Models
{
    public class Student
    {
       //https//docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/ validation?view=aspnetcore-2.2*/

        [RegularExpression(@"(S|s)\d{7}")]
        [Required ]
        public string StudentID { get; set; } = "";
        
        [Required]
     
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 2)]
        public string FirstName { get; set; } = "";

        // [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        //[StringLength(60, MinimumLength = 3)]
        // [Range(1, 100)]
        [Required]
        [StringLength(60, MinimumLength = 3)]//least number of 3 characters in the string
        public string LastName { get; set; } = "";
        
        [Required(ErrorMessage ="Please enter date in format dd-mm-yyyy")]//error message given, not needed as its not a text field
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }


        //date put in a text box
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }


        [Required]
        public int NumberOfModules { get; set; }

        [Range(50, 250)]//sets range from 50 to 250
        [Required]
        public int Height { get; set; } 


        //email property
        [RegularExpression(@"")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }="";


        //https//docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        //email Confrim property


        // [Compare(Email)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public String ConfirmEmail { get; set; } = "";
    }
}
