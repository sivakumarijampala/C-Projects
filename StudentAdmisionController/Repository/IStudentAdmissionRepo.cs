using StudentAdmision.Models;

namespace StudentAdmision.Repository
{
    public interface IStudentAdmissionRepo
    {
        public IEnumerable<StudentAd> GetAllAdmissions();
    }
}
