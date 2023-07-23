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
      Vendor newVendor1 = new Vendor("Jane's Bun's", "Cafe", "jane@buns.com", "123-123-1234", 1);
      Vendor newVendor2 = new Vendor("Mike's Cookies", "Grocery", "mike@cookies.com", "345-345-3456", 2);
      Assert.AreNotEqual(newVendor1.Id, newVendor2.Id);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor01 = "Jane's Buns";
      string vendor02 = "Mike's Cookies";
      Vendor newVendor1 = new Vendor(vendor01, "Cafe", "jane@buns.com", "123-123-1234", 1);
      Vendor newVendor2 = new Vendor(vendor02, "Grocery", "mike@cookies.com", "345-345-3456", 2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "Holiday order 2023"; 
      string description = "Two dozen of each seasonal cookie.";
      int price = 200;
      DateTime date = new DateTime(2023, 12, 01);

      Order newOrder = new Order(title, description, price, date);
      string vendor = "Mike's Cookies";
      Vendor newVendor = new Vendor(vendor);
      newVendor.AddOrder(newOrder);
      List<Order> results = newOrder.Orders;
      CollectionAssert.AreEqual(newOrder, results);
    }
  }
}