


using StudentAttendance.Models;

namespace StudentAttendance.Repository
{
    public interface IStudentAttendanceRepo
    {
        public IEnumerable<StudentAtt> GetAllAttendances();
    }
}
