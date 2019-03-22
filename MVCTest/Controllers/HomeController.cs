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
            //Student data = new Student();
            var list = new List<Student>
            {
                new Student("1", "小明", 80),
                new Student("2", "小華", 70),
                new Student("3", "小英", 60),
                new Student("4", "小李", 50),
                new Student("5", "小張", 90),
            };  
            
                
            ViewBag.Date = date;
            ViewBag.List = list;
            return View();
        }
    }
}