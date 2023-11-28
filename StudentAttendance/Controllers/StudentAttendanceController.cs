using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendance.Models;
using StudentAttendance.Repository;

namespace StudentAttendance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        public IStudentAttendanceRepo StudentAttendanceRepo { get; set; }

        public StudentAttendanceController(IStudentAttendanceRepo studentAttendanceRepo) { 
            StudentAttendanceRepo = studentAttendanceRepo;
        }

        [HttpGet("getallattendance")]
        public ActionResult<StudentAtt> GetAllAttendances()
        {
              IEnumerable<StudentAtt> StudentAttendances=StudentAttendanceRepo .GetAllAttendances();
            if(StudentAttendances != null)
            {
                return Ok(StudentAttendances);
            }
            else
            {
                return NotFound("Student attendance not found");
            }
        }
    }
}
