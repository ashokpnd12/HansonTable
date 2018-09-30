using HandsonTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsonTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { empId=101,name="Ramzan Khan",designation="Software Developer",isPunctual=true,performance="Best",mobile="9675432468",ctc=3.5m,doj=new DateTime(01/03/2018) },
                new Employee { empId=102,name="Suman Choudhury",designation="Software Developer",isPunctual=false,performance="Best",mobile="8764563278",ctc=3.4m,doj=new DateTime(15/02/2018) },
                new Employee { empId=103,name="Ashok Pandey",designation="Software Developer",isPunctual=true,performance="Worst",mobile="9876567543",ctc=3.25m,doj=new DateTime(01/02/2018) }
            };
            return View(emp);
        }

        public ActionResult jQueryDemo()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}