using Expense.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Expense.Models.Concrete
{
    public class UserRepository : IUserRepository
    {
        private ExpenseEntities db = new ExpenseEntities();

        public IEnumerable<User> Users
        {
            get { return db.User; }
        }

        public bool UserAuth(string userName, string password)
        {
            User user = db.User.FirstOrDefault(p => p.UserID == userName && p.Password == password);

            return user != null ? true : false;
        }
    }
}