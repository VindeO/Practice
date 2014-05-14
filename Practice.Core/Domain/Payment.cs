using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  public class Payment:  IObjectWithState
   
  {
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public DateTime  Date { get; set; }
    public Order Order { get; set; } 
    [NotMapped]
    public State State { get; set; }
  }
}