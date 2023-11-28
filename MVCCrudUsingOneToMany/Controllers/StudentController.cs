using MVCCrudUsingOneToMany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudUsingOneToMany.Controllers
{
    public class StudentController : Controller
    {
        StudentDepartmentDBContext dBContext = new StudentDepartmentDBContext();
        // GET: Student
        public  ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public string Insert(Student student)
        {
            dBContext.Students.Add(student);
            dBContext.SaveChanges();
            return "insertion completed";
        }
    }
}