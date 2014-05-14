using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  public class Order : IObjectWithState
   
  {
    public Order()
    {
      LineItems = new List<LineItem>();
      Payments = new List<Payment>();
    }

    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public Nullable<DateTime> DueDate { get; set; }
    public bool OnlineOrder { get; set; }
    public string SalesOrderNumber { get; set; }
    public string PurchaseOrderNumber { get; set; }
    public int CustomerId { get; set; }
    public decimal SubTotal { get; set; }
    public string Comment { get; set; }
    public DateTime ModifiedDate { get; set; }
   // public Customer Customer { get; set; }
    public ICollection<LineItem> LineItems { get; set; }
    public ICollection<Payment> Payments { get; set; }
    public int PromotionId { get; set; }
    [NotMapped]
    public State State { get; set; }
  }
}