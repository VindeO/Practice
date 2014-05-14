using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  public class SalaryHistory:  IObjectWithState
  
  {
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Salary { get; set; }
    
    [NotMapped]
    public State State { get; set; }
  }
}