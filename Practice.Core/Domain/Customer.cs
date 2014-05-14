using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practice.Core.Domain
{
  public class Customer : Person
  {
    public Customer()
    {
      Orders = new List<Order>();
      Addresses = new List<Address>();
    }

    public ICollection<Order> Orders { get; set; }

    public string SalesPersonId { get; set; }

    public ICollection<Address> Addresses { get; set; }
  }
}