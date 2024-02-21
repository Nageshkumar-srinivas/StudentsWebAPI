using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Data;
using StudentsAPI.Models.Domain;

namespace StudentsAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsDbContext dbContext;

        public StudentsController(StudentsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = dbContext.Students.ToList();
            return Ok(students);
        }

        [HttpGet]
        [Route("id")]
        public IActionResult GetStudent(int id)
        {
            var student = dbContext.Students.Find(id);

            if(student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            if(student == null)
            {
                return BadRequest();
            }

            Student student1 = new Student
            {
                Name = student.Name,
                Age = student.Age,
                Class = student.Class,
                Id = student.Id,
                TeacherId = student.TeacherId,
                Teacher = student.Teacher,
            };
            
            dbContext.Students.Add(student1);
            dbContext.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var student = dbContext.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            dbContext.Students.Remove(student);
            dbContext.SaveChanges();

            return Ok();

        }
    }
}
