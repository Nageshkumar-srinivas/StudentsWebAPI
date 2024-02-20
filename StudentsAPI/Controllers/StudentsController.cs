using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Data;

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



    }
}
