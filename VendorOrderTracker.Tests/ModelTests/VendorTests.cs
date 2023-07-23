using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Sample Vendor", "Sample Type", "sample@vendor.com", "123-456-7890", 1);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]

    public void VendorProperties_UpdateVendorProperties_Vendor()
    {
      Vendor newVendor = new Vendor("Sample Vendor", "Sample Type", "sample@vendor.com", "123-456-7890", 1);

      newVendor.Name = "Sample Vendor";
      newVendor.Type = "Sample Type";
      newVendor.Email = "sample@vendor.com";
      newVendor.PhoneNumber = "123-456-7890";
      newVendor.Orders = new List<Order>();

      Assert.AreEqual("Sample Vendor", newVendor.Name);
      Assert.AreEqual("Sample Type", newVendor.Type);
      Assert.AreEqual("sample@vendor.com", newVendor.Email);
      Assert.AreEqual("123-456-7890", newVendor.PhoneNumber);
      Assert.IsNotNull(newVendor.Orders);
    }
    [TestMethod]
    public void VendorId_SetUniqueVendorId_Vendor()
    {
      Vendor newVendor1 = new Vendor("Vendor 1", "Type 1", "vendor1@example.com", "111-111-1111", 1);
      Vendor newVendor2 = new Vendor("Vendor 2", "Type 2", "vendor2@example.com", "222-222-2222", 2);
      Assert.AreNotEqual(newVendor1.Id, newVendor2.Id);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor01 = "Jane's Buns";
      string vendor02 = "Mike's Cookies";
      Vendor newVendor1 = new Vendor(vendor01, "Type 1", "jane@buns.com", "111-111-1111", 1);
      Vendor newVendor2 = new Vendor(vendor02, "Type 2", "mike@cookies.com", "222-222-2222", 2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}