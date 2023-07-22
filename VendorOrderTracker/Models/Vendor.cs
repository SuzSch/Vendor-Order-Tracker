using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static int lastVendorId = 0;

    public Vendor()
    {
      VendorId = ++lastVendorId;
    }

    public string VendorName { get; set; }
    public string VendorType { get; set; }
    public string VendorEmail { get; set; }
    public string VendorPhoneNumber { get; set; }
    public List<Order> Orders { get; set; }
    public int VendorId { get; set; }
  }
}






