using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpdatedDataPassingToView.Models;

namespace UpdatedDataPassingToView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            Student s1 = new Student()
            {
                Name = "Tanvir Ahmed",
                Id = "1234",
                Dob = "12.12.12"
            };
            

            /*string[] names = new string[3];
            names[0] = "Tanvir";
            names[1] = "Rayied";
            names[2] = "Asif";


            ViewBag.Names = names;*/
           

            return View(s1);
        }

        public ActionResult List()
        {
            List<Student> s = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                Student ss = new Student()
                {
                    Name = "Tanvir Ahmed" + (i + 1),
                    Id = "1234",
                    Dob = "12.12.12"

                };
                s.Add(ss);
                

            }
            return View(s);
        }
    }
}