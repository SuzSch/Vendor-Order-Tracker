using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorType { get; set; }
    public string VendorEmail { get; set; }
    public string VendorPhoneNumber { get; set; }
    public List<Order> Orders { get; set; }
    public int VendorId { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      VendorId = _instances.Count;
      Vendors = new List<Vendor> { };
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}