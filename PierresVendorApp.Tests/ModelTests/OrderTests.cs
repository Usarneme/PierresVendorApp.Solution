using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresVendorApp.Models;

namespace PierresVendorApp.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order myOrder = new Order("title", "description");
      Assert.AreEqual(typeof(Order), myOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_HasTitle_Title()
    {
      string expectedTitle = "title";
      Order myOrder = new Order(expectedTitle, "description");
      Assert.AreEqual(expectedTitle, myOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_HasDescription_Description()
    {
      string expectedDescription = "Description";
      Order myOrder = new Order("title", expectedDescription);
      Assert.AreEqual(expectedDescription, myOrder.Description);
    }
  }
}