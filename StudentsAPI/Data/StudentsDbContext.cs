using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models.Domain;

namespace StudentsAPI.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
