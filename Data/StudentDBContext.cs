using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options):base(options) { 
            
        }

        public DbSet<Students> students { get; set; } 

    }
}
