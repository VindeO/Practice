using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
 
  public class Product : IObjectWithState
  
  {
    public Product()
    {
      LineItems = new List<LineItem>();
    }

    public int ProductId { get; set; }
    [Required, StringLength(100)]
    public string Name { get; set; }
    [Required, StringLength(10)]
    public string ProductNumber { get; set; }
    public String Color { get; set; }
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
    public string Size { get; set; }
    public int CategoryId { get; set; }
    public DateTime SellStartDate { get; set; }

    public Nullable<decimal> ShippingWeight { get; set; }
    public Nullable<DateTime> SellEndDate { get; set; }
    public Nullable<DateTime> DiscontinuedDate { get; set; }

    public byte[] Photo { get; set; }


    public ICollection<LineItem> LineItems { get; set; }
    public Category Category { get; set; }
    
    [NotMapped]
    public State State { get; set; }
  }
}