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

    [HttpGet("/vendors/{id}/orders/{orderId}")]
    public ActionResult ShowSingleOrder(int vendorId, int orderId)
    {
      Vendor thisVendor = Vendor.FindById(vendorId);
      Order thisOrder = Order.FindById(orderId);
      Dictionary<string, object> orderData = new Dictionary<string, object>();
      orderData.Add("vendor", thisVendor);
      orderData.Add("order", thisOrder);
      return View("SingleOrder", orderData);
    }

    [HttpPost("/vendors/{id}/orders/{orderId}")]
    public ActionResult CreateNewOrder(string vendorId, string title, string price, string description, string date)
    {
      int priceAsInt = int.Parse(price);
      DateTime orderDate = Convert.ToDateTime(date);
      int idAsInt = int.Parse(vendorId);
      Vendor thisVendor = Vendor.FindById(idAsInt);
      Order newOrder = new Order(title, description, priceAsInt, orderDate);
      thisVendor.AddOrder(newOrder);
      Dictionary<string, object> orderData = new Dictionary<string, object>();
      orderData.Add("vendor", thisVendor);
      orderData.Add("order", newOrder);
      return View("SingleOrder", orderData);
    }
  }
}
