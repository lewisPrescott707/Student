using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    /// <summary> 
    /// Standard class sealed due to virtual type initialized within constructor
    /// </summary>
    /// <value> 
    /// StudentName is not null
    /// </value>
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
    }

    /// <summary>
    /// Standard class sealed due to virtual type initialized within constructor
    /// </summary>
    public class Standard
    {
        public Standard()
        {
            Students = new List<Student>();
        }

        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
