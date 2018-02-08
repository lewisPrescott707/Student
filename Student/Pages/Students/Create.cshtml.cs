using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student.Models;

namespace Student.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentContext _context;
        private readonly IStandards _standards;
        public List<SelectListItem> StandardName { get; set; }
        public CreateModel(StudentContext context, IStandards standards)
        {
            _context = context;
            _standards = standards;
        }

        /// <summary>
        /// Get List of standards to display in dropdown list
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            StandardName = _standards.GetAllStandards();
            return Page();
        }

        [BindProperty]
        public Models.Student Student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}