
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice.Core.Domain
{
  public class Shipment:   IObjectWithState

  {
    public int ShipmentId { get; set; }
    public int OrderId { get; set; }
    public bool EntireOrder { get; set; }
    public ICollection<LineItem> LineItemsInShipment { get; set; }
    public DateTime DateShipped { get; set; }
    public int ShipperId { get; set; }
    public Shipper Shipper { get; set; }

    [NotMapped]
    public State State { get; set; }
  }
}