using MVCCrudUsingOneToOne.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrudUsingOneToOne.Controllers
{
    public class StudentController : Controller
    {
        public StudentDBContext dBContext = new StudentDBContext();

        // Insert Student
        public ActionResult Insert()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Insert(Student student)
        {
            dBContext.Students.Add(student);
            dBContext.SaveChanges();
            return RedirectToAction("GetStudents", "Student");
        }

        //getStudents
        public ActionResult GetStudents()
        {
            List<Student> students = dBContext.Students.Include("Department").ToList();
            return View(students);
        }


        //deletemethod
        public ActionResult Delete(int id)
        {
            Student student=dBContext.Students.Find(id);
            dBContext.Students.Remove(student);
            dBContext.SaveChanges();
            return RedirectToAction("GetStudents", "Student");
        }

        public ActionResult Edit(int id)
        {
            Student student = dBContext.Students.Include(s => s.Department).FirstOrDefault(s => s.StudentId == id);
            return View(student);
        }


        [HttpPost]
        public ActionResult Edit(Student student,int id)
        {
           Student stud= dBContext.Students.Find(id);
            stud.StudentName = student.StudentName;
            stud.StudentAge = student.StudentAge;
            if (stud.Department == null)
            {
                stud.Department = new Department();
            }
            stud.Department.DeptName = student.Department.DeptName;
            stud.Department.Location = student.Department.Location;
            dBContext.SaveChanges();
            return RedirectToAction("GetStudents", "Student");
        }
    }
}