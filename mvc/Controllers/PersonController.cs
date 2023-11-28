using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class PersonController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: Person
        public ActionResult Index()
        {
            bool isTableExists = db.Database
                .SqlQuery<int>("SELECT COUNT(*) FROM information_schema.tables WHERE table_name = 'Person'")
                .SingleOrDefault() > 0;

            if (isTableExists)
            {
                return View(db.People.ToList());
            }
            else
            {
                ViewBag.Message = "Person table does not exist in the database.";
                return View();
            }
        }


    }
}
