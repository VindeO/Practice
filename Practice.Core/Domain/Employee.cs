using System;
using System.Collections.Generic;

namespace Practice.Core.Domain
{
  public class Employee : Person
  {
    public Employee()
    {
      SalaryHistories = new List<SalaryHistory>();

    }

    public bool SalesPerson { get; set; }
    public DateTime HireDate { get; set; }
    public Nullable<DateTime> EndDate { get; set; }
    public ICollection<SalaryHistory> SalaryHistories { get; set; }
  }
}