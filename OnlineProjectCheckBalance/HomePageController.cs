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
                if(project.BalanceAdds.Where(x=>x.UserName==objbalanceAdd.UserName && x.Password==objbalanceAdd.Password).FirstOrDefault()==null)//If UserName and Password is null user cant login if it is not null user can login
                {
                    ViewBag.data = "Invalid UserName and Password";
                 //   return RedirectToAction("CheckBalance", "HomePage");
                }
                else
                {
                    ViewBag.data = "Login Successfully";
                   return RedirectToAction("CheckBalance", "HomePage");//It user is login successfully then it  will Redirect to CheckBalance Page
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

                var data = project.BalanceAdds.Where(obj1 => obj1.AccountNo==obj.AccountNo ).FirstOrDefault();//If the Accountno is correct then it will show the balance
                 ViewBag.show = "The available balance in the current account is " + data.Amount;
               
            }
            else
            {
                
               ViewBag.show = "AccountNo should be Provided";
            }
            return View();
            //   return RedirectToAction("Home1", "HomePage");
        }
    }
}
