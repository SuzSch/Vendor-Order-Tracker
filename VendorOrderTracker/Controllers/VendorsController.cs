using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;


namespace VendorOrderTracker.Controllers
{
  public class VendorController : Controller
  {

    [HttpGET("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = List.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }
  }
}