using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassingToView.Controllers
{
    public class PersonController : Controller
    {
        // DataPassing from action to view(Viewbag ,Viewdata)
        //Viewbag -dynamic object ;global object of asp.net
        public ActionResult List()
        {
            int a = 10;
            int b = 20;
            int c = a + b;

            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.C = c;

            string[] names = new string[3];
            names[0] = "Tanvir";
            names[1] = "Rayied";
            names[2] = "Asif";


            ViewBag.Names=names;
            //viewdata- dictionary syntax follows; php=associative array
            ViewData["A"] = a;
            ViewData["B"] = b;
            ViewData["C"] = c;



            var d = "10";//set datatype in compile time
            //d.jkjk = "121212"; //error occured in compile time
            //d = 12;
            dynamic e = 20;//datatype declared in run time
            //e.jkjk = "121212";//error in runtime


            //issues of viewbag and viewdata(object passing)
            return View();
        }
        public ActionResult CreatePerson()
        {
            return View();
        }
    }
}