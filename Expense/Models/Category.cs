//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Expense.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Receipt = new HashSet<Receipt>();
        }
    
        public int CatID { get; set; }
        public string Desp { get; set; }
    
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
