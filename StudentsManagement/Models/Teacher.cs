using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field Is Requierd")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "This Field Is Requierd")]
        public string? Subject { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
