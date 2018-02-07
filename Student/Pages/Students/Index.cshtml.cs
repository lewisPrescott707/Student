using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student.Models;
using Student = Student.Models.Student;

namespace Student.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentContext _context;
        public List<Models.Student> Students { get; set; }

        public IndexModel(StudentContext context)
        {
            _context = context;
        }

        public IList<Models.Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Students = new List<Models.Student>()
            {
               new Models.Student()
               {
                       StandardId = 1,
                       StudentId = 1,
                       StudentName = "Aris",
                       Standard = new Standard()
               }
            };
            Student = Students;
        }
    }
}
