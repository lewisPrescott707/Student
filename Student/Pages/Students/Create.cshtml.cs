using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Student.Models;

namespace Student.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Student.Models.StudentContext _context;
        public List<SelectListItem> StandardName { get; set; }
        public CreateModel(Student.Models.StudentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            StandardName = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "A",
                    Value = "A",
                },
                new SelectListItem()
                {
                    Text = "B",
                    Value = "B",
                },
            };
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