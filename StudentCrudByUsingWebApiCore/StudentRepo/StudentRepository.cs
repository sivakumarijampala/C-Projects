using StudentCrudByUsingWebApiCore.Models;

namespace StudentCrudByUsingWebApiCore.StudentRepo
{
    public interface StudentRepository
    {
        public IEnumerable<Student> GetAllStudents();

        public Student GetStudentById(int studentId);

        public Student SaveStudent(Student student);

        public void DeleteStudent(int studentId);

        public Student UpdateStudent(int studentId,Student student);
    }
}
