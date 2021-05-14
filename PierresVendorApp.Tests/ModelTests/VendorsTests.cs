using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresVendorApp.Models;

namespace PierresVendorApp.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor myVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), myVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_HasName_Name()
    {
      string expectedVendorName = "vendor";
      Vendor myVendor = new Vendor(expectedVendorName, "dsecription");
      Assert.AreEqual(expectedVendorName, myVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_HasDescription_Description()
    {
      string expectedVendorDescription = "description";
      Vendor myVendor = new Vendor("name", expectedVendorDescription);
      Assert.AreEqual(expectedVendorDescription, myVendor.Description);
    }

    [TestMethod]
    public void VendorConstructor_HasOrders_Orders()
    {
      List<Order> expectedVendorOrders = new List<Order>();
      Vendor myVendor = new Vendor("name", "description");
      myVendor.Orders = expectedVendorOrders;
      CollectionAssert.AreEqual(expectedVendorOrders, myVendor.Orders);
    }

    [TestMethod]
    public void VendorConstructor_CreatingVendorAddsVendorToVendorsList_VendorListContainsVendor()
    {
      Vendor myVendor = new Vendor("name", "description");
      Assert.AreEqual(Vendor.GetAllVendors().Contains(myVendor), true);
    }

    [TestMethod]
    public void Vendor_FindById_Vendor()
    {
      Vendor expectedVendor = new Vendor("name", "description");
      // NOTE: 6 is a magic number (this is brittle but I believe fine for testing purposes)
      // IdCounter doesn't ever decrement so it is the ID# at this point
      // as 6 is how many tests have instantiated a Vendor instance prior to this test
      // even though the instances are disposed, I did not want my IdCounter to be reset to 0
      // to ensure no Id#s are ever reused by the application under any (incl. testing) circumstances
      Vendor foundVendor = Vendor.FindById(6);
      Assert.AreEqual(expectedVendor.Id, foundVendor.Id);
    }

    [TestMethod]
    public void Vendor_AddOrder_UpdatesOrdersList()
    {
      Vendor myVendor = new Vendor("name", "description");
      Order newOrder = new Order("title", "description", 10, DateTime.Now);
      myVendor.AddOrder(newOrder);
      Assert.AreEqual(myVendor.Orders.Count, 1);
    }
  }
}
