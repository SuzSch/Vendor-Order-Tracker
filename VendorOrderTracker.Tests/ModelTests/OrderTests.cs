using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsOrders_OrdersList()
    {
      string title01 = "Valentine's Day 2024 Order";
      string description01 = "10 dozen red velvet cupcakes";
      int price01 = 400;
      DateTime date01 = new DateTime(2024, 2, 01);

      string title02 = "Winter Holiday 2023 Order";
      string description02 = "Two dozen of each holiday cookie";
      int price02 = 200;
      DateTime date02 = new DateTime(2023, 12, 01);

      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Winter Holiday 2023 Order";
      string description = "Two dozen of each holiday cookie";
      int price = 200;
      DateTime date = new DateTime(2023, 12, 01);
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Valentine's Day 2024 Order";
      string description01 = "10 dozen red velvet cupcakes";
      int price01 = 400;
      DateTime date01 = new DateTime(2024, 2, 01);

      string title02 = "Winter Holiday 2023 Order";
      string description02 = "Two dozen of each holiday cookie";
      int price02 = 200;
      DateTime date02 = new DateTime(2023, 12, 01);

      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}