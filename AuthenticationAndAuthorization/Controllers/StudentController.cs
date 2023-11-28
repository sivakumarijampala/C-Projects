using AuthenticationAndAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Http;

namespace AuthenticationAndAuthorization.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        public StudentDBContext DBContext=new StudentDBContext();
        // GET: Student
        [HttpGet]
        public string Index()
        {
            DBContext.Students.ToList();
            return "hey"; 
        }
    }
}