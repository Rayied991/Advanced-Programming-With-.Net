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
            UMSEntities1 db = new UMSEntities1();
            //var data = from st in db.Students select st;
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            UMSEntities1 db = new UMSEntities1();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            UMSEntities1 db = new UMSEntities1();
            var student = (from st in db.Students
                           where st.Id == Id
                           select st).First();
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            using (UMSEntities1 db = new UMSEntities1())
            {
                Student entity = (from st in db.Students
                                  where st.Id == s.Id
                                  select st).FirstOrDefault();
                /*entity.Name= s.Name;
                entity.Dob= s.Dob;
                entity.Gender= s.Gender;
                entity.Cgpa= s.Cgpa;*/
                db.Entry(entity).CurrentValues.SetValues(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


        }
        public ActionResult Details(int Id)
        {
            UMSEntities1 db = new UMSEntities1();
            var student = (from st in db.Students
                           where st.Id == Id
                           select st).First();
            return View(student);
        }

        public ActionResult Delete(int Id)
        {
            using (UMSEntities1 db = new UMSEntities1())
            {
                Student s = (from st in db.Students
                             where
                             st.Id == Id
                             select st).FirstOrDefault();
                return View(s);
            }
        }
        [HttpPost]
        public ActionResult Delete(Student s)
        {
            using (UMSEntities1 db = new UMSEntities1())
            {
                Student entity = (from st in db.Students
                                  where st.Id == s.Id
                                  select st).FirstOrDefault();
                db.Students.Remove(entity);
                db.SaveChanges();
                return RedirectToAction("Index");

            }





        }
    }
}