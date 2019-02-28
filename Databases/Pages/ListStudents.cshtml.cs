using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Databases.Pages
{
    public class ListStudentsModel : PageModel
    {
        private readonly StudentContext _db;

        public CreateStudentModel(StudentContext db)
        {
            _db = db;
        }


        public IList<Student> StudentsDB { get; private set; }
        public async Task OnGetTaskAsync()

        
        {

            StudentsDB = await _db.Students.AsNoTrackingg().ToListAsync();
        }
    }
}