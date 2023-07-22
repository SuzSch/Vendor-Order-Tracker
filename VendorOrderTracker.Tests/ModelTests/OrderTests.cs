using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreateOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]

    public void OrderProperties_UpdateOrderProperties_Order()
    {
      Order newOrder = new Order();

      newOrder.Title = "Winter Holiday 2023 Order";
      newOrder.Description = "Two dozen of each holiday cookie";
      newOrder.Price = 200;
      newOrder.Date = new DateTime(2023, 12, 01);
      

      Assert.AreEqual("Winter Holiday 2023 Order", newOrder.Title);
      Assert.AreEqual("Two dozen of each holiday cookie", newOrder.Description);
      Assert.AreEqual(200, newOrder.Price);
      Assert.AreEqual(new DateTime(2023, 12, 01), newOrder.Date);
    }
  }
}