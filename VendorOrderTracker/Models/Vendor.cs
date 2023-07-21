using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string vendorname)
    {
      VendorName = vendorname;
      _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

  }
}