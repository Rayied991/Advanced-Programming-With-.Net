using Form_Receive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Form_Receive.Controllers
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
        public ActionResult Create()
        {
            return View();
        }
        //receive data from form (4 ways)
       /* public ActionResult CreateSubmit()
        {
            Student s=new Student();
            
            //way 1-from HttprequestBase Request
            s.Name = Request["Name"];
            s.Id = Request["Id"];
            s.Dob = Request["Dob"];
            
            return View(s);
        }*/

        //way-2: Formcollection Object=mvc framework class
       /* public ActionResult CreateSubmit(FormCollection fc)
        {
            Student s = new Student();
            //var c = Request;//all information
            //form=necessary info's
            s.Name = fc["Name"];
            s.Id = fc["Id"];
            s.Dob = fc["Dob"];


            return View(s);
        }*/
        //way-3:from direct variables
       /* public ActionResult CreateSubmit(string Name, string Id,string Dob)
        {
            Student s = new Student();
            var c = Request;
            s.Name = Name;
            s.Id = Id;
            s.Dob =Dob;
            return View(s);
        }*/
       //Way-4:Object Oriented Approach(receive via object)
        public ActionResult CreateSubmit(Student s)
        {

            return View(s);
        }
    }
}