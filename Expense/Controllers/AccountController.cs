using Expense.Models.Abstract;
using Expense.Models.Entities;
using Expense.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Expense.Controllers
{
    public class AccountController : Controller
    {
        private IAuthProvider auth;
        private IUserRepository user;

        public AccountController(IAuthProvider authProvider, IUserRepository userRepository)
        {
            auth = authProvider;
            user = userRepository;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (System.Web.HttpContext.Current.Request.IsAuthenticated)
                {
                    return View("Main", "Product");
                }

                try
                {
                    bool result = user.UserAuth(model.UserName, model.Password);
                    if (result)
                    {
                        Account account = new Account(model.UserName);
                        auth.SignIn(model.UserName, false);
                        Session["User"] = account;
                        return Redirect(Url.Action("Main", "Product"));
                    }
                    else
                    {
                        ModelState.AddModelError("", "User name and password are not mateched");
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Please reauthenticate in www.keystonerealtors.ca and try again.";
                }

                return View();
            }
            else
            {
                return View();
            }
        }
    }
}