using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountProject.Models;

namespace AccountProject.Controllers
{
    
    public class HomePageController : Controller
    {
        CRUDDBEntities db = new CRUDDBEntities();
        // GET: HomePage
        public ActionResult Home1()
        {
            return View();
        }
        public ActionResult Menu1()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(AmountAdd obj,string btn)
        {
            
             if(btn=="Add Money")
            {
                var data = db.AmountAdds.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();
                data.Amount += obj.Amount;
                int message = db.SaveChanges();
                if (message == 1)
                {
                    ViewBag.data = "Money Added Successfully";
                }
                else
                {
                    ViewBag.data = "Money not added";
                }

            }
            return View();
           // return RedirectToAction("Home1", "HomePage");
         
        }
        public ActionResult CheckBalance()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckBalance(AmountAdd obj, string btn)
        {
            if (btn == "Check Balance")
            {
               
                    var data = db.AmountAdds.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();
                    ViewBag.show = "The available balance in the current account is " + data.Amount;
                
            }
            return View();
            //   return RedirectToAction("Home1", "HomePage");
        }
        public ActionResult Transaction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Transaction(AmountAdd obj, string btn)
        {
            if (btn == "Transfer")
            {
                var data = db.AmountAdds.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();
                //var data1 = db.AmountAdds.Where(obj3 => obj3.AccountNo == obj2.AccountNo).FirstOrDefault();
                if (obj.Amount <= data.Amount)
                {
                    data.Amount -= obj.Amount;
                    int mes = db.SaveChanges();
                    if (mes == 1)
                    {
                        ViewBag.data = "Transfer done";
                        //if (obj.Amount <= data1.Amount)
                        //{
                        //    data1.Amount += obj2.Amount;
                        //}
                       // int mes = db.SaveChanges();
                    }
                    else
                    {
                        ViewBag.data = "Transfer not done";
                    }
                }
                else
                {
                    ViewBag.data = "Insufficient Balance";
                }

            }
            return View();

        }
    }

}