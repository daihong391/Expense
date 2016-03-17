using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense.Models.Abstract
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }
        bool UserAuth(string userName, string password);
    }
}
