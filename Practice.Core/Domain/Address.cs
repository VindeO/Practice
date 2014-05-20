using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  [Table("ShippingAddresses")]
  public class Address : IObjectWithState
    
  {
    public int Id { get; set; }

    [StringLength(50)]
    public string Street1 { get; set; }
    [StringLength(50)]
    public string Street2 { get; set; }
    [StringLength(50)]
    public string City { get; set; }
    [StringLength(50)]
    public string Region { get; set; }

    [StringLength(50)]
    public string Country { get; set; }
    [StringLength(50)]
    public string PostalCode { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    
    [NotMapped]
    public State State { get; set; }
  }
}
