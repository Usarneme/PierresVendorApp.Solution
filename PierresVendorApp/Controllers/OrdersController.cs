using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PierresVendorApp.Models;

namespace PierresVendorApp.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor thisVendor = Vendor.FindById(id);
      return View(thisVendor);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult CreateNewOrder(string vendorId, string title, string price, string description, string date)
    {
      int idAsInt = int.Parse(vendorId);
      int priceAsInt = int.Parse(price);
      DateTime orderDate = Convert.ToDateTime(date);
      Vendor thisVendor = Vendor.FindById(idAsInt);
      Order newOrder = new Order(title, description, priceAsInt, orderDate);
      thisVendor.AddOrder(newOrder);
      Dictionary<string, object> vendorData = new Dictionary<string, object>();
      vendorData.Add("vendor", thisVendor);
      vendorData.Add("order", newOrder);
      return View("SingleOrder", vendorData);
    }
  }
}
