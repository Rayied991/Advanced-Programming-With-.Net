using DbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbFirst.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            UMSEntities1 db=new UMSEntities1();
            //var data = from st in db.Students select st;
            var data=db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s )
        {
            UMSEntities1 db = new UMSEntities1();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            UMSEntities1 db =new UMSEntities1();
            var student=(from st in db.Students
                         where st.Id == Id
                         select st).First();
            return View(student);
        }

    }
}