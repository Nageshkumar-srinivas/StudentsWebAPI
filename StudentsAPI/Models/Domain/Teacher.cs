using System.ComponentModel.DataAnnotations;

namespace StudentsAPI.Models.Domain
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Subject { get; set; }
    }
}
