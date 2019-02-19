using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EntAppSecond.Pages.Models;

namespace EntAppSecond.Pages
{
    public class CreateModel : PageModel
    {

        public string Message { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            Message = "post has just happened";

            if (ModelState.IsValid)
            {
                Message += "and all is well with the world";
            }
            else
            {
                Message+="Heuston WE HAVE A PROBLEM";
            }
        }
    }
}