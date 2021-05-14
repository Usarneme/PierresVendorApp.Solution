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

  }
}