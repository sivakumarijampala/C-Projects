using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmision.Models;
using StudentAdmision.Repository;

namespace StudentAdmision.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmisionController : ControllerBase
    {
        public IStudentAdmissionRepo studentAdmissionRepo { get; set; }
        public StudentAdmisionController(IStudentAdmissionRepo studentAdmissionRepo)
        {
            this.studentAdmissionRepo = studentAdmissionRepo;
        }
        
        [HttpGet("getalladmissions")]
        public ActionResult<StudentAd> GetAllStudentAdmissions()
        {
            IEnumerable<StudentAd> StudentAdmissions=studentAdmissionRepo.GetAllAdmissions();
            if(StudentAdmissions!=null)
            {
                return Ok(StudentAdmissions);
            }
            else
            {
                return NotFound("student admissions not found");
            }
        }
    }
}
