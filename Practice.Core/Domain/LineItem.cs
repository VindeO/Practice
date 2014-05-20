using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  public class LineItem : IObjectWithState
  {
      public int LineItemId { get; set; }

      public int OrderId { get; set; }
      public int ProductId { get; set; }

      public int OrderQty { get; set; }
      public Nullable<decimal> UnitPrice { get; set; }
      public Nullable<decimal> UnitPriceDiscount { get; set; }

      public decimal LineTotal { get; set; }

      public Product Product { get; set; }
      public Order Order { get; set; }

      public Nullable<int> ShipmentId { get; set; }

      [NotMapped]
      public State State { get; set; }
  }
}