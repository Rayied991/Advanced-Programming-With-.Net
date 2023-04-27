using System;
using FormValidation.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class RegController : Controller
    {
        // Annotation-> rules amplied
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration model) { 
            if(ModelState.IsValid) {
            return RedirectToAction("Show");
                    }
            return View(model);

        }
        public ActionResult Show() {
            List<Registration> students = new List<Registration>();
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                /*Student student = new Student();
                student.Name = "Student " + i;
                student.Id = "Id-" + i;
                student.Roll = i;
                students.Add(student);*/

                students.Add(new Registration()
                {
                    Id = "Id-" + i,
                    Name = "Student " + random.Next(100, 500),
                    
                     
                });
            }


            return View(students);
            return View();
        }

       
    }
}