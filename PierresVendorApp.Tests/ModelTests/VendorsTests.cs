using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVendorApp.Models;

namespace PierresVendorApp.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor myVendor = new Vendor("name", "description", new List<Order>());
      Assert.AreEqual(typeof(Vendor), myVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_HasName_Name()
    {
      string expectedVendorName = "vendor";
      Vendor myVendor = new Vendor(expectedVendorName, "dsecription", new List<Order>());
      Assert.AreEqual(expectedVendorName, myVendor.Name);
    }

    [TestMethod]
    public void VendorConstructor_HasDescription_Description()
    {
      string expectedVendorDescription = "description";
      Vendor myVendor = new Vendor("name", expectedVendorDescription, new List<Order>());
      Assert.AreEqual(expectedVendorDescription, myVendor.Description);
    }

    [TestMethod]
    public void VendorConstructor_HasOrders_Orders()
    {
      List<Order> expectedVendorOrders = new List<Order>();
      Vendor myVendor = new Vendor("name", "description", expectedVendorOrders);
      CollectionAssert.AreEqual(expectedVendorOrders, myVendor.Orders);
    }

    [TestMethod]
    public void VendorConstructor_CreatingVendorAddsVendorToVendorsList_VendorListContainsVendor()
    {
      Vendor myVendor = new Vendor("name", "description", new List<Order>());
      Assert.AreEqual(Vendor.GetAllVendors().Contains(myVendor), true);
    }
  }
}
