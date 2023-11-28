using StudentCrudByUsingWebApiCore.Exceptions;
using StudentCrudByUsingWebApiCore.Models;
using StudentCrudByUsingWebApiCore.StudentRepo;

namespace StudentCrudByUsingWebApiCore.StudentRepositoryImpl
{
    public class StudentRepoImpl : StudentRepository

    {
        public readonly StudentDbContext studentDbContext;

        public StudentRepoImpl(StudentDbContext studentDbContext)
        {
          this.studentDbContext = studentDbContext;
        }

        public void DeleteStudent(int studentId)
        {
            Student studentToDelete=studentDbContext.Students.Find(studentId);
            if(studentToDelete != null)
            {
                studentDbContext.Students.Remove(studentToDelete);
                studentDbContext.SaveChanges();
            }
            else
            {
                throw new StudentNotFoundException($"student with ID:{studentId} not found ");
            }
            
           
        }

        public IEnumerable<Student> GetAllStudents()
        {
           return studentDbContext.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
           return studentDbContext.Students.Find(studentId);
        }

        public Student SaveStudent(Student student)
        {
           studentDbContext.Students.Add(student);
            studentDbContext.SaveChanges();
            return student;

        }

        public Student UpdateStudent(int studentId, Student student)
        {
            Student existingStudent=studentDbContext.Students.Find(studentId);
            if(existingStudent != null)
            {
                existingStudent.StudentName = student.StudentName;
                existingStudent.StudentAge = student.StudentAge;
                existingStudent.StudentFees=student.StudentFees;
                studentDbContext.SaveChanges();
                return existingStudent;
            }
            else
            {
                throw new StudentNotFoundException($"student with ID:{studentId} not found ");
            }
        }
    }
}
