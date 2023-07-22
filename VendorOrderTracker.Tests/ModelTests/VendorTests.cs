using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreateVendor_Vendor()
    {

      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]

    public void VendorProperties_UpdateVendorProperties_Vendor()
    {
      Vendor newVendor = new Vendor();

      newVendor.VendorName = "Sample Vendor";
      newVendor.VendorType = "Sample Type";
      newVendor.VendorEmail = "sample@vendor.com";
      newVendor.VendorPhoneNumber = "123-456-7890";
      newVendor.Orders = new List<Order>();

      Assert.AreEqual("Sample Vendor", newVendor.VendorName);
      Assert.AreEqual("Sample Type", newVendor.VendorType);
      Assert.AreEqual("sample@vendor.com", newVendor.VendorEmail);
      Assert.AreEqual("123-456-7890", newVendor.VendorPhoneNumber);
      Assert.IsNotNull(newVendor.Orders);
    }
    [TestMethod]

    public void VendorId_SetVendorId_IdIsSet()

  }
}