using Expense.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Expense.Models.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private ExpenseEntities db = new ExpenseEntities();

        public IEnumerable<Category> Categories
        {
            get { return db.Category; }
        }
    }
}