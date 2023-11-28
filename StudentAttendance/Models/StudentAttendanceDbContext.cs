using Microsoft.EntityFrameworkCore;

namespace StudentAttendance.Models
{
    public class StudentAttendanceDbContext:DbContext
    {
        public StudentAttendanceDbContext(DbContextOptions<StudentAttendanceDbContext> options) : base(options) {

        }

        public DbSet<StudentAtt> StudentAttendances { get; set; }
    }
}
