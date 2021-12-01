using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class Studnet : Controller
    { 
    
            // GET: Music
            public ActionResult Index()
            {
                return View();
            }
            public string Welcome()
            {
                return "Hello, Weclome Studnet";
            }
            public string ShowInfo(string StudnetName)
            {
                return "You Secured " + StudnetName + " First Position";
            }

        
    }



}
