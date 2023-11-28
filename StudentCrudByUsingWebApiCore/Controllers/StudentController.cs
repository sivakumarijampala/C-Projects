using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrudByUsingWebApiCore.Models;
using StudentCrudByUsingWebApiCore.StudentRepo;

namespace StudentCrudByUsingWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        public  StudentRepository studentRepository { get; set; }
        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        //get students
        
        [HttpGet("getStudents")]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            IEnumerable<Student> students=studentRepository.GetAllStudents().ToList();
            if (students != null)
            {
                return Ok(students);
            }
            else
            {
                return NotFound(new {message="students not found in database"});
            }
        }


        //get student by id
        [HttpGet("getstudentbyid/{studentId}")]
        public ActionResult GetStudentByStudentId(int studentId)
        {
            Student student=studentRepository.GetStudentById(studentId);
            if(student != null)
            {
                return Ok(student);
            }
            else
            {
                return NotFound(new { message = $"student not found with ID:{studentId}" });
            }
        }


        //save student
        [HttpPost("savestudent")]
        public ActionResult SaveStudent([FromBody]Student student)
        {
           if(student == null)
            {
                return BadRequest(new { message = "Invalid student data" });
            }
            try
            {
                Student cretedStudent=studentRepository.SaveStudent(student);
                return Ok(new { message = "student created successfully" });
               // return CreatedAtAction(nameof(GetStudentByStudentId), new { studentId = cretedStudent.StudentId },new { message = $"student created successfully ", cretedStudent });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message =$"failed to save student.{ex.Message}" });
              
            }

        }

        //delete student

        [HttpDelete("deletestudent/{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            if (studentId < 0)
            {
                return BadRequest(new { message = "invalid student id" });
            }
            try
            {
                studentRepository.DeleteStudent(studentId);
                return Ok(new { message = $"student deleted successfully with studentId:{studentId}" });
            }
            catch(Exceptions.StudentNotFoundException ex)
            {
                return NotFound(new {message=ex.Message});
            }
        }

        //update student
        [HttpPut("updatestudent/{studentId}")]
        public ActionResult UpdateStudent(int studentId,[FromBody]Student student)
        {
            if (studentId < 0)
            {
                return BadRequest(new { message = $"invalid student Id:{studentId}" });
            }
            try
            {
                Student stud=studentRepository.UpdateStudent(studentId, student);
                return Ok(new {message=$"student updated successfully with id:{studentId}",stud});
            }
            catch (Exceptions.StudentNotFoundException ex)
            {
              return NotFound(new {message=ex.Message});
            }
        }

    }
}
