using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Models.Domain
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Class { get; set; }
        public int Age { get; set; }
        public int TeacherId { get; set; }
        

        public Teacher? Teacher { get; set; }
    }
}
