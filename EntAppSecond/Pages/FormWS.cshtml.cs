using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {
        [BindProperty]
        public string ProductCode { get; set; }
        [BindProperty]
        public string Colour { get; set; }
        [BindProperty]
        public string Consent { get; set; }

        public String Message { get; set; } = "";
        public String Message1 { get; set; } = "";
        public String Message2 { get; set; } = "";
        public void OnGet()
        {

        }
        public void OnPost()
        {
            Message = string.Format("The coloue is {0}", Colour);
            Message1 = string.Format("The product id is {0}", ProductCode);
            Message2= string.Format("oK i CONSENT {0}",Consent);


        }
    }
}