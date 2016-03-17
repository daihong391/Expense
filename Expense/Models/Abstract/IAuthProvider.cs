using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.Models.Abstract
{
    public interface IAuthProvider
    {
        void SignIn(string userName, bool createPersistentCookie);
        void SignOut();
    }
}
