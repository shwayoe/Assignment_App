using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;




namespace YuneNadiOo.Controllers
{
  
    public class HomeController : Controller
    {
        AssignmentEntities2 ae = new AssignmentEntities2();

        //int i = 0;
      
        public ActionResult Index()
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