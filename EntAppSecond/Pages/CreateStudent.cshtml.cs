using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class CreateStudentModel : PageModel
    {

        [BindProperty]
        public  FirstName { get; set; } = "";


        public void OnGet()
        {



        }
    }
}