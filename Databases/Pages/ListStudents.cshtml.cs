using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Databases.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore; 

namespace Databases.Pages
{
    public class ListStudentsModel : PageModel
    {
        private readonly StudentContext _db;

       public ListStudentsModel(StudentContext db)
       {
            _db = db;
        }


       public IList<Student> StudentsDB { get; private set; }
       public async Task OnGetTaskAsync()

        
       {

            //StudentsDB = await _db.Students.AsNoTracking().ToListAsync();
        }
    }
}