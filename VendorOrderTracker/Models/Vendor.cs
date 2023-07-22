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
  }
}