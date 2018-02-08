using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Student.Models
{
    public class FakeStandards : IStandards
    {
        public List<SelectListItem> GetAllStandards()
        {
            return new List<SelectListItem>
            {
                new SelectListItem()
                {
                    Value = "A",
                    Text = "Grade A"
                },
                new SelectListItem()
                {
                    Value = "B",
                    Text = "Grade B"
                }
            };
        }

        public List<Student> GetAllStudentsByStandardId(int id)
        {
            var standardList = new List<Standard>()
            {
                new Standard()
                {
                    StandardId = 1,
                    StandardName = "A",
                    Description = "A Grade",
                    Students = new List<Student>() {
                        new Student() {
                            StandardId = 1,
                            StudentName = "Aris",
                            StudentId = 1
                        } 
                    }
                }
            };
            var students = standardList.First(x => x.StandardId == id).Students.ToList();
            return students;
        }
    }
}
