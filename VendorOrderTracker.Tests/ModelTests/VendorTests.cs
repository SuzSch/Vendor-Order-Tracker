using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_SetsProperties()
    {
      string businessName = "Jane's Place";
      string managerName = "Jane Smith";
      string contactEmail = "janesmith@gmail.com";
      int phoneNumber = 1234567890;
      Vendor newVendor = new Vendor(businessName, managerName, contactEmail, phoneNumber);
      Assert.AreEqual(businessName, newVendor.BusinessName);
      Assert.AreEqual(managerName, newVendor.ManagerName);
      Assert.AreEqual(contactEmail, newVendor.ContactEmail);
      Assert.AreEqual(phoneNumber, newVendor.PhoneNumber);
    }
  }
}