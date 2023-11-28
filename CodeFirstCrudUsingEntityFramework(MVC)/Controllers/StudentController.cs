using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst.Controllers
{
    public class StudentController : Controller
    {
       
        
        // GET: Student
        public ActionResult StudentDisplay()
        {

            StudentDBContext dBContext = new StudentDBContext();
            List<Student> students= dBContext.Students.ToList();
            return View(students);
        }


      //insert Student
          public ActionResult Insert()
          {
            
            return View();


          }

        //insert post

        [HttpPost]
        public ActionResult Insert(Student student)
        {
            StudentDBContext dBContext = new StudentDBContext();
            dBContext.Students.Add(student);
            dBContext.SaveChanges();
            return RedirectToAction("StudentDisplay", "Student");
        }


        //deleting
        public ActionResult Delete(int id)
        {
            StudentDBContext dBContext = new StudentDBContext();
            Student student=dBContext.Students.Find(id);
            dBContext.Students.Remove(student);
            dBContext.SaveChanges();

            return RedirectToAction("StudentDisplay", "Student");
        }

        //editing

        public ActionResult Edit(int id)
        {

            StudentDBContext dBContext = new StudentDBContext();
            Student student = dBContext.Students.Find(id);

            return View(student);

        }

        [HttpPost]
        public ActionResult Edit(Student stu, int id)

        {
            StudentDBContext dBContext = new StudentDBContext();
           
           Student st= dBContext.Students.Find(id);
            st.Name = stu.Name;
            st.Age = stu.Age;
           
            dBContext.SaveChanges();
            return RedirectToAction("StudentDisplay", "Student");
        }




    }
}