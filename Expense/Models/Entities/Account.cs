using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Expense.Models.Entities
{
    public class Account
    {
        public string UserName { get; set; }

        public Account()
        {

        }

        public Account(string userName)
        {
            if (!String.IsNullOrEmpty(userName))
            {
                UserName = userName;
            }
        }
    }
}