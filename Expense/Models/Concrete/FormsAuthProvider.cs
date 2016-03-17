using Expense.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Expense.Models.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public void SignIn(string userName, bool createPersistentCookie)
        {
            if (String.IsNullOrEmpty(userName))
                throw new ArgumentException("Value can not be null or Empty", "userName");
            else
                FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);

        }

        public void SignOut()
        {
            if (HttpContext.Current.Request.IsAuthenticated)
            {
                try
                {
                    FormsAuthentication.SignOut();
                }
                catch { }
                HttpContext.Current.Session["User"] = null;
            }
        }
    }
}