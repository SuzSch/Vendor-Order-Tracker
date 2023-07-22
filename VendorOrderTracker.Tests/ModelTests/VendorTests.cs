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
    public void VendorId_SetUniqueVendorId_Vendor()
    {
      Vendor newVendor1 = new Vendor();
      Vendor newVendor2 = new Vendor();
      Assert.AreNotEqual(newVendor1.VendorId, newVendor2.VendorId);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor01 = "Jane's Buns";
      string vendor02 = "Mike's Cookies";
      Vendor newVendor1 = new Vendor(vendor01);
      Vendor newVendor2 = new Vendor(vendor02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}