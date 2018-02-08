using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Student.Models
{
    public interface IStandards
    {
        List<SelectListItem> GetAllStandards();
        List<Student> GetAllStudentsByStandardId(int id);
    }
}
