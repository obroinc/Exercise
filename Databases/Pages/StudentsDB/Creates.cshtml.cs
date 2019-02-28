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
        public Student Student { get; set; } = new Student();

        private readonly StudentContext _db;

        public CreateStudentModel(StudentContext db)
        {
            _db = db;
        }



        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                

                _db.StudentsDB.Add(Student);
                await _db.SaveChangesAsync();

                return RedirectToPage("ConfirmStudent");

            }
            else
            {
                return Page();
            }
        }
}