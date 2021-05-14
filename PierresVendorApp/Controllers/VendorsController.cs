using Microsoft.AspNetCore.Mvc;
using PierresVendorApp.Models;

namespace PierresVendorApp.Controllers
{
  public class VendorsController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
