using System.ComponentModel.DataAnnotations;

namespace StudentsManagement.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field Is Requierd")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Range(1, 100, ErrorMessage = "Credits must be between 1 and 100")]
        public int Hours { get; set; }
        public Teacher? teacher { get; set; }
        public Student? student { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }
    }
}
