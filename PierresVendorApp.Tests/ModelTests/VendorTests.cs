using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresVendorApp.Models;

namespace PierresVendorApp.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor myVendor = new Vendor("name");
      Assert.AreEqual(typeof(Vendor), myVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_HasName_Name()
    {
      string expectedVendorName = "vendor";
      Vendor myVendor = new Vendor(expectedVendorName);
      Assert.AreEqual(expectedVendorName, myVendor.Name);
    }

  }
}