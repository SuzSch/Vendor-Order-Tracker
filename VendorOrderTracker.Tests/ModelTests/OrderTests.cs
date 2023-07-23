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
      Order newOrder = new Order("Winter Holiday 2023 Order", "Two dozen of each holiday cookie", 200, new DateTime(2023, 12, 01));
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]

    public void OrderProperties_UpdateOrderProperties_Order()
    {
      Order newOrder = new Order("Winter Holiday 2023 Order", "Two dozen of each holiday cookie", 200, new DateTime(2023, 12, 01));

      string title = "Winter Holiday 2023 Order";
      string description = "Two dozen of each holiday cookie";
      int price = 200;
      DateTime date = new DateTime(2023, 12, 01);


      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]

    public void MakeOrder_MakeOrder_Order()
    {
      Order newOrder = new Order("Winter Holiday 2023 Order", "Two dozen of each holiday cookie", 200, new DateTime(2023, 12, 01));

      string newTitle = "Valentine's Day 2024 Order";
      string newDescription = "10 dozen red velvet cupcakes";
      int newPrice = 400;
      DateTime newDate = new DateTime(2024, 2, 01);

      newOrder.Title = newTitle;
      newOrder.Description = newDescription;
      newOrder.Price = newPrice;
      newOrder.Date = newDate;

      Assert.AreEqual(newTitle, newOrder.Title);
      Assert.AreEqual(newDescription, newOrder.Description);
      Assert.AreEqual(newPrice, newOrder.Price);
      Assert.AreEqual(newDate, newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}