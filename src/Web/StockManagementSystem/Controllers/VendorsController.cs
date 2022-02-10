using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    public class VendorsController : Controller
    {
        public IActionResult VendorsList()
        {
            Vendor vendor = new Vendor();
            List<Vendor> vendors = vendor.GetAllVendor(null);
            return View(vendors);
        }
        [HttpPost]
        public IActionResult AddNewVendor(String name, String phoneNumber, int vendorId)
        {
            Vendor vendor = new Vendor();
            vendor.VendorId = vendorId;
            vendor.Name = name;
            vendor.PhoneNumber = phoneNumber;
            TempData["succMsg"] = vendor.SaveVendor(vendor);
            return RedirectToAction("VendorsList");
        }
        [HttpPost]
        public IActionResult DeleteVendorById(int vendorId)
        {
            Vendor vendor = new Vendor();
            vendor.DeleteVendorById(vendorId);
            return RedirectToAction("VendorsList");
        }
    }
}
