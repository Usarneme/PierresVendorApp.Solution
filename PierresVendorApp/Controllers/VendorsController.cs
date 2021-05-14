using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresVendorApp.Models;

namespace PierresVendorApp.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAllVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
