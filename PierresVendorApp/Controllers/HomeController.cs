using Microsoft.AspNetCore.Mvc;

namespace PierresVendorApp.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
