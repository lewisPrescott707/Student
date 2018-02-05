using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student.Models;

namespace Student.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentContext _context;

        public IndexModel(StudentContext context)
        {
            _context = context;
        }

        public IList<Models.Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
