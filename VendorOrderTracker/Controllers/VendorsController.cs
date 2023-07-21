using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Vendor newVendor = new Vendor("Add a vendor to the list");
      return View(newVendor);
    }

  }
}