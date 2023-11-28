using StudentAttendance.Models;

namespace StudentAttendance.Repository
{
    public class StudentAttendanceRepoImpl : IStudentAttendanceRepo
    {
        public StudentAttendanceDbContext Context { get; set; }
        public StudentAttendanceRepoImpl(StudentAttendanceDbContext context)
        {
            Context = context;
        }
        public IEnumerable<StudentAtt> GetAllAttendances()
        {
             return Context.StudentAttendances.ToList();
        }
    }
}
