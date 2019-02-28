using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Databases.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Databases.Pages.StudentsDB
{
    public class CreatesModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }
        public void OnGet()
        {

        }
    }
}