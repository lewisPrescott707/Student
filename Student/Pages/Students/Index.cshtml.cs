using System.Collections.Generic;
using System.Linq;
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
        private readonly IStandards _standards;
        public List<Standard> Students { get; set; }

        public IndexModel(IStandards standards)
        {
            _standards = standards;
        }

        public IList<Models.Student> Student { get;set; }

        /// <summary>
        /// TODO: Implement url parameter with standard id
        /// </summary>
        /// <returns>
        /// Students with Standard id of 1
        /// </returns>
        public async Task OnGetAsync()
        {
            Student = _standards.GetAllStudentsByStandardId(1);
        }
    }
}
