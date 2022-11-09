using System.ComponentModel.DataAnnotations;
using University2.Models.DataModels;

namespace University2.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        public int CourseId { get; set; }

        public virtual Course Course { get; set; } = new Course();

        [Required]
        public string ListChapters = string.Empty;
    }
}
