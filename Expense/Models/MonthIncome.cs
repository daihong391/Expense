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
    
    public partial class MonthIncome
    {
        public int MonID { get; set; }
        public string UserID { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Income { get; set; }
    
        public virtual User User { get; set; }
    }
}