using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student.Models;

namespace Student.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly StudentContext _context;

        public DetailsModel(StudentContext context)
        {
            _context = context;
        }

        public Models.Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.SingleOrDefaultAsync(m => m.StudentId == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
