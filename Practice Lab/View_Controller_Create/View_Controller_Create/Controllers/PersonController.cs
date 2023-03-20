using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View_Controller_Create.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult List()
        {
            return View();
        }
        public ActionResult CreatePerson()
        {
            return View();
        }
    }
}