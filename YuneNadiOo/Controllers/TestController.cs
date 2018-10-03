using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace YuneNadiOo.Controllers
{
    public class TestController : Controller
    {
        AssignmentEntities2 ae = new AssignmentEntities2();
        //int sum = 0;
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Testing(int? id=1, int result=0)
        {

            var data = new Test();
           
            if (id != null)
            {
                data = ae.Tests.Where(g => g.Qid == id).FirstOrDefault();
                var radio = Request.Form["Answer"];
                var answer = Request.Form["ActualAnswer"];
                if (radio!=null && answer != null)
                {
                    if (radio == answer)
                    {
                        result += 1;
                    }
                 
                }
               
               
            }
            if (data == null) {
                //return HttpNotFound();
                //return View(result);
                return RedirectToAction("Result", "Test", new { a = result });//yno

            }
           
            ViewData["result"] = result;  
            return View(data);

        }

        public ActionResult Result(int a)
        {
            return View(a);
        }
        public ActionResult AdminLogin() {

            var adminname = Request.Form["adname"];
            var password = Request.Form["pass"];
            var admin1 = Request.Form["AdminName"];
            var pass1 = Request.Form["AdminPass"];
            if (adminname != null && password != null)
            {
                if (adminname == admin1 && password == pass1)
                {
                    return RedirectToAction("Index", "Information");
                    //TempData["testmsg"] = "<script>alert('Answer is corrected');</script>";
                }
                else {
                    TempData["testmsg"] = "<script>alert('Do not Allow');</script>";
                }
            }

            return View(from Admin in ae.Admins.Take(10) select Admin);
        }
    
        //public ActionResult CheckRadio(int id1, int result,FormCollection fc)
        //{

        //    int Id = id1;
        //    var radio = Request.Form["Answer"];
        //    var answer = Request.Form["ActualAnswer"];
        //    //var qid = Request.Form["QuestionID"];
        //    //int Qid = int.Parse(qid);
        //    //Qid++;
        //    if (radio == answer)
        //    {
        //        TempData["testmsg"] = "<script>alert('Answer is corrected');</script>";
        //        //result += 1;
        //        result = result + 1;
         
        //    }
        //    else
        //    {

        //        TempData["testmsg"] = "<script>alert('Answer is incorrected');</script>";

        //    }
        //    //var answer = new SelectList(ae.Tests.ToList(), "Actual_Answer");
        //    //if (radio = answer)
        //    //{ 
        //    return RedirectToAction("Testing", "Test", new { id = Id, result = result });
            
        //    //new { id = Qid };



        //}

    }
}
    