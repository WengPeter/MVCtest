using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            DateTime date = DateTime.Now;
            Student data = new Student();
            var list = new list<Student>
            {

            };  
            
                
            ViewBag.Date = date;
            ViewBag.Student = data;
            ViewBag.List = list;
            return View();
        }
    }
}