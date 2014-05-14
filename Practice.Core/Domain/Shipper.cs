using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  public class Shipper :IObjectWithState
 
  {
    public int ShipperId { get; set; }

    [StringLength(100)] public string Name { get; set; }
    
    [NotMapped]
    public State State { get; set; }
  }
}