using OnlineWalletProject.DBModel;
using OnlineWalletProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineWalletProject.Controllers
{
    public class AccountController : Controller
    {
        OnlineProjectEntities objOnlineProjectEntities = new OnlineProjectEntities();
        // GET: Account
        public ActionResult Home1()
        {
            return View();
        }
        public ActionResult Register()
        {
            UserModel objuserModel = new UserModel();
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModel objuserModel)
        {
            if (ModelState.IsValid)
            {
                User objUser = new DBModel.User();
                objUser.UserName = objuserModel.UserName;
                objUser.Email = objuserModel.Email;
                objUser.Password = objuserModel.Password;
                objUser.Email = objuserModel.Email;
                objUser.Date_of_Birth = objuserModel.Date_of_Birth;
                objUser.PhoneNo = objuserModel.PhoneNo;
                objUser.AccountNo = objuserModel.AccountNo;
                objUser.Amount = objuserModel.Amount;
                objOnlineProjectEntities.Users.Add(objUser);
                objOnlineProjectEntities.SaveChanges();
                objuserModel = new UserModel();
                //objuserModel.SuccessMessage = "Registered Successfully";
                ViewBag.data = "User is Successfully Registered";
                //  return RedirectToAction("Home1", "Account");
            }
            return View();
        }
        public ActionResult Login()
        {
            LoginModel objloginModel = new LoginModel();
            return View(objloginModel);
        }
        [HttpPost]
        public ActionResult Login(LoginModel objloginModel)
        {
            if (ModelState.IsValid)
            {
                if (objOnlineProjectEntities.Users.Where(m => m.Email == objloginModel.Email && m.Password == objloginModel.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", " Invalid Email and Password");
                    return View();
                }
                else
                {
                    Session["Email"] = objloginModel.Email;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Home1", "Account");
        }


        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(User obj, string btn)
        {

            if (btn == "Add Money")
            {
                var data = objOnlineProjectEntities.Users.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();
                data.Amount += obj.Amount;
                int message = objOnlineProjectEntities.SaveChanges();
                if (message == 1)
                {
                    ViewBag.data = "Money Added Successfully";
                }
                else
                {
                    ViewBag.data = "Money not added";
                }

            }
            // return View();
            // return RedirectToAction("Home1", "HomePage");
          else if (btn == "View Balance")
            {

                var data = objOnlineProjectEntities.Users.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();//If the Accountno is correct then it will show the balance
                ViewBag.show = "The available balance in the current account is " + data.Amount;
                // ViewBag.show = "Details are wrong";
            }
            return View();

        }
        public ActionResult CheckBalance()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckBalance(User obj, string btn)
        {
            if (btn == "Check Balance")
            {

                var data = objOnlineProjectEntities.Users.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();//If the Accountno is correct then it will show the balance
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
        public ActionResult Transfer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Transfer(User obj, string btn)
        {
            if (btn == "Transfer")
            {

                var data = objOnlineProjectEntities.Users.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();
                if (obj.Amount <= data.Amount)
                {
                    data.Amount -= obj.Amount;
                    int mes = objOnlineProjectEntities.SaveChanges();
                    if (mes == 1)
                    {
                        ViewBag.data = "Transfer done";
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


                //  return View();
                //   return RedirectToAction("Home1", "HomePage");
            }
            if (btn == "View Balance")
                {

                    var data = objOnlineProjectEntities.Users.Where(obj1 => obj1.AccountNo == obj.AccountNo).FirstOrDefault();//If the Accountno is correct then it will show the balance
                    ViewBag.show = "The available balance in the current account is " + data.Amount;
                    // ViewBag.show = "Details are wrong";
                }
            //else
            //{
            //    //ViewBag.show = "The available balance in the current account is " + data.Amount;
            //    ViewBag.show = "AccountNo should be Provided";
            //}
            //return View();
            return View();

        }
          
    }
}