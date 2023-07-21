using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string BusinessName { get; set; }
    public string MangerName { get; set; }
    public string ContactEmail { get; set; }
    public int PhoneNumber { get; set; }

    public Vendor(string businessName, string managerName, string contactEmail, int phoneNumber)
    {
      BusinessName = businessName;
      MangerName = managerName;
      ContactEmail = contactEmail;
      PhoneNumber = phoneNumber;
    }

  }
}