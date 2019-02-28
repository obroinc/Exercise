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

        [RegularExpression(@"(S|s)\d{7}")]//Student number desins with S/s followed by 7 no.
        [Display(Name="Please supply student ID")]//Message diaplayed for user-lable
        [Required ]
        public string StudentID { get; set; } = "";

        [RegularExpression(@"\w\'-,\s]{2,}", ErrorMessage="Must be at leat 2 chatacters long")]
        //@\w(2,50) will also work fine-letters stc with a min of 2 char and max of 50
        //The error massage will be displayed instead of red expression
        [Required(ErrorMessage = "Please enter your First Name")]//error message displayed
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 2)]//min of 2 characters
        public string FirstName { get; set; } = "";
        

        [Display(Name = "Last Name")]
        [RegularExpression(@"\w\'-,\s]{2,}")]//also @.(3,) gives  min of 3 char
        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(60, MinimumLength = 3)]//least number of 3 characters in the string
        public string LastName { get; set; } = "";


        [Display(Name = "DOB")]
        [Required(ErrorMessage ="Please enter date in format dd-mm-yyyy")]//error message given, not needed as its not a text field
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }


        //date put in a text box
        [Required(ErrorMessage = "Please enter DOB as dd-mm-yyyy")]
        [RegularExpression(@"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }


        [Required]
        //[Range(1,int32.MaxValue)]
        [Display(Name = "Number of Modules")]
        public int NumberOfModules { get; set; }

        [Range(50, 250)]//sets range from 50 to 250
        [Display(Name = "Height please")]
        [Required(ErrorMessage = "Please enter your height, it must be between 50 and 250 cm")]
        public int Height { get; set; }


        //email property
        //[RegularExpression(@"")]
        [Display(Name = "email")]
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        //https//docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        //email Confrim property


      

        [Required]
        [Display(Name = "Confirm email")]
        [DataType(DataType.EmailAddress)]
                public String ConfirmEmail { get; set; } = "";

       // [Compare(public String ConfirmEmail { get; set; } = "";). Equals(Student.Email)]
    }

}
