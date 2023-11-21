using Microsoft.EntityFrameworkCore;

namespace StudentAdmision.Models
{
    public class StudentAdmissionDbContext:DbContext
    {
        public StudentAdmissionDbContext(DbContextOptions<StudentAdmissionDbContext> options) : base(options) { }

        public DbSet<StudentAd> StudentAdmissions { get; set; }
    }
}
