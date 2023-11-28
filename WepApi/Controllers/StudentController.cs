using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using System.Web.UI.WebControls;
using WepApi.Models;



namespace WepApi.Controllers
{
    public class StudentController : ApiController
    {
        public StudentDBContext context = new StudentDBContext();

        // GET: Student
        [Route("api/Student/getstudents")]
        public IEnumerable<Student> Get()
        {
            List<Student> students = context.Students.ToList();
            return students;
        }

        [HttpGet]
        [Route("api/Student/getstudentById/{id}")]
        public HttpResponseMessage GetStudentById(int id)
        {
           Student student= context.Students.FirstOrDefault(e => e.Id == id);
            if (student== null)
            {
                Request.CreateResponse(HttpStatusCode.NotFound);

            }

           return Request.CreateResponse(HttpStatusCode.OK, student);
        }

        [HttpGet]
        [Route("api/Student/cal")]
        public int Calculation()
        {
            int sum = 10 + 20;
            return sum;
        }




        [Route("api/Student/ca")]
        public int Cal()
        {
            int sub = 10 - 20;
            return sub;
        }


        //create student
        /*[HttpPost]
        [Route("api/Student/createstudent")]
         */
        //if we give return type as void it will give status (204No Content) even it add student 
        //we need to give proper http response  srtudent created

        /*public void CreateStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }*/



        //create student
        [HttpPost]
        [Route("api/Student/createstudent")]

        public HttpResponseMessage createstudent([FromBody] Student student)
        {
            Student stu=context.Students.Add(student);
            context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, stu);
        }


        //delete student
        [HttpDelete]
        [Route("api/Student/deletestudent/{id}")]
        public HttpResponseMessage deletestudent(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student==null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            context.Students.Remove(student);
            context.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK,"deleted successfully");
           
            
        }


        //edit student
        [HttpPut]
        [Route("api/Student/editstudent/{id}")]
         public HttpResponseMessage editstudent(int id,[FromBody]Student student)
        {
            var stud=context.Students.FirstOrDefault(s => s.Id == id);
            stud.Name = student.Name;
            if(stud.Id == id)
            {
                Request.CreateResponse(HttpStatusCode.NotFound, stud);
            }
            context.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "edit successfulll");
        }

    }
}
