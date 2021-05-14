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
      Vendor myVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), myVendor.GetType());
    }

  }
}