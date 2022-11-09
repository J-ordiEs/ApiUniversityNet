using System.ComponentModel.DataAnnotations;
using University2.Models.DataModels;

namespace University2.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
