using StudentAdmision.Models;

namespace StudentAdmision.Repository
{
    public class StudentAdmissionRepoImpl : IStudentAdmissionRepo
    {
        public StudentAdmissionDbContext Context { get; set; }
        public StudentAdmissionRepoImpl(StudentAdmissionDbContext studentAdmissionDbContext) { 
            Context = studentAdmissionDbContext;
        }
        public IEnumerable<StudentAd> GetAllAdmissions()
        {
           return Context.StudentAdmissions.ToList();
        }
    }
}
