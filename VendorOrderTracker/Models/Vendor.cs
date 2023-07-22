using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string VendorName { get; set; }
    public string VendorEmail { get; set; }
    public string VendorPhone { get; set; }
    public string Id { get; set; }

    public List<Order> Orders { get; set; }
  }

  public Vendor(string VendorName)
  {
    VendorName = VendorName;
    _instances.Add(this);
    Id = _instances.Count;
    Orders = new List<Order> { };
  }
}