using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

using WepApiCrudUsingEntityFramework.Models;

namespace WepApiCrudUsingEntityFramework.Controllers
{
    public class StudentController : Controller
    {
        public StudentDBContext dbcontext = new StudentDBContext();
        // GET: Student
        [HttpGet]
        public IEnumerable<Student> Index()
        {
            List<Student> students=dbcontext.Students.ToList();
            return students;
        }

        [HttpPost]
        public string Display()
        {
            return "hello";
        }
    }
}