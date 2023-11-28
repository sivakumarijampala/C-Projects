using CrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Controllers
{
    public class StudentController : Controller
    {

        //student table creation
        public ActionResult CreateTable()
        {

            StudentDBClass studentDB = new StudentDBClass();
            studentDB.Create();
            ViewBag.Message = "Table created successfully";
            return View();
        }



        //student insert action
        //get request
        public ActionResult Insert()
        {
            return View();
        }

        //post request
       
        [HttpPost]
        public ActionResult Insert(StudentModel studentModel)
        {
            StudentDBClass studentDB = new StudentDBClass();
            studentDB.Insert(studentModel);
            return RedirectToAction("GetStudents", "Student");
        }


        //getting details from database
        public ActionResult GetStudents()
        {

            StudentDBClass studentDB = new StudentDBClass();
            List<StudentModel> students=studentDB.GetAll();
             return View(students);
        }

        //deleting
        public ActionResult Delete(int id)
        {
            StudentDBClass studentDB = new StudentDBClass();
            studentDB.Delete(id);
            return RedirectToAction("GetStudents", "Student");
        }


        //editing

        public ActionResult Edit(int id)
        {
           
            StudentDBClass studentDB = new StudentDBClass();
            StudentModel student = studentDB.GetStudentById(id);

            return View(student);

        }

        [HttpPost]
        public ActionResult Edit(StudentModel stu,int id)
            
        {
            StudentDBClass studentDB = new StudentDBClass();

            studentDB.Update(stu,id);
            return RedirectToAction("GetStudents", "Student");
        }
    }      
}
