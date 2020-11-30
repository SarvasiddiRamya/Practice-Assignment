using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BalanceProject.Models;

namespace BalanceProject.Controllers
{

    public class HomePageController : Controller
    {
        CRUDDBEntities project = new CRUDDBEntities();
        // GET: HomePage
        public ActionResult Home1()
        {
            return View();
        }
        public ActionResult Balance()
        {
            return View();
        }
        public ActionResult Login()
        {
            BalanceAdd objbalanceAdd = new BalanceAdd();
            return View(objbalanceAdd);
        }
        [HttpPost]
        public ActionResult Login(BalanceAdd objbalanceAdd)
        {
            if(ModelState.IsValid)
            {
                if(project.BalanceAdds.Where(x=>x.UserName==objbalanceAdd.UserName && x.Password==objbalanceAdd.Password).FirstOrDefault()==null)
                {
                    ViewBag.data = "Invalid UserName and Password";
                 //   return RedirectToAction("CheckBalance", "HomePage");
                }
                else
                {
                    ViewBag.data = "Login Successfully";
                   return RedirectToAction("CheckBalance", "HomePage");
                }
            }
            return View();
          // return RedirectToAction("CheckBalance","HomePage");
        }
        public ActionResult CheckBalance()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckBalance(BalanceAdd obj, string btn)
        {
            if (btn == "Check Balance")
            {

                var data = project.BalanceAdds.Where(obj1 => obj1.AccountNo==obj.AccountNo ).FirstOrDefault();
                 ViewBag.show = "The available balance in the current account is " + data.Amount;
               // ViewBag.show = "Details are wrong";
            }
            else
            {
                //ViewBag.show = "The available balance in the current account is " + data.Amount;
               ViewBag.show = "AccountNo should be Provided";
            }
            return View();
            //   return RedirectToAction("Home1", "HomePage");
        }
    }
}

