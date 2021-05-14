using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresVendorApp.Models;

namespace PierresVendorApp.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order myOrder = new Order("title", "description", 1, DateTime.Now);
      Assert.AreEqual(typeof(Order), myOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_HasTitle_Title()
    {
      string expectedTitle = "title";
      Order myOrder = new Order(expectedTitle, "description", 1, DateTime.Now);
      Assert.AreEqual(expectedTitle, myOrder.Title);
    }

    [TestMethod]
    public void OrderConstructor_HasDescription_Description()
    {
      string expectedDescription = "Description";
      Order myOrder = new Order("title", expectedDescription, 1, DateTime.Now);
      Assert.AreEqual(expectedDescription, myOrder.Description);
    }

    [TestMethod]
    public void OrderConstructor_HasPrice_Price()
    {
      int expectedPrice = 5;
      Order myOrder = new Order("title", "description", expectedPrice, DateTime.Now);
      Assert.AreEqual(expectedPrice, myOrder.Price);
    }

    [TestMethod]
    public void OrderConstructor_HasDate_Date()
    {
      DateTime expectedDate = DateTime.Now;
      Order myOrder = new Order("title", "description", 1, expectedDate);
      Assert.AreEqual(expectedDate, myOrder.OrderPlacedDate);
    }

    [TestMethod]
    public void OrderConstructor_AddingOrder_ContainsOrderInOrdersList()
    {
      Order myOrder = new Order("title", "description", 1, DateTime.Now);
      Assert.AreEqual(Order.GetAllOrders().Contains(myOrder), true);
    }

    [TestMethod]
    public void Order_FindById_Order()
    {
      Order expectedOrder = new Order("title", "description", 1, DateTime.Now);
      // NOTE: 7 is a magic number (this is brittle but I believe fine for testing purposes)
      // IdCounter doesn't ever decrement so it is the ID# at this point
      // as 7 is how many tests have instantiated a Order instance prior to this test
      // even though the instances are disposed, I did not want my IdCounter to be reset to 0
      // to ensure no Id#s are ever reused by the application under any (incl. testing) circumstances
      Order foundOrder = Order.FindById(7);
      Console.WriteLine(expectedOrder.Id);
      Assert.AreEqual(expectedOrder.Id, foundOrder.Id);
    }
  }
}