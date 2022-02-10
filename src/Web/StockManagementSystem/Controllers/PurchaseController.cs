using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult PurchaseEntry()
        {
            Vendor vendor = new Vendor();
            ViewData["Vendors"] = vendor.GetAllVendor(null);

            ItemCategory category = new ItemCategory();
            ViewData["Categories"] = category.GetAllItemCategories(null);

            return View();
        }

        [HttpPost]
        public IActionResult PurchaseEntry(Purchase purchase)
        {
            Item item = new Item();
            string errorMsg=purchase.SavePurchase(purchase);
            TempData["succMsg"] = errorMsg;
            return RedirectToAction("PurchaseEntry");
        }
 

        [HttpPost]
        public JsonResult GetItemByCategory(int cid)
        {
            Item item = new Item();
            List<Item> items = new List<Item>();
            items = item.GetAllItemsByCatg(cid);
            List<Dictionary<string, string>> itemDicts = new List<Dictionary<string, string>>();

            if (items.Count > 0)
            {
                foreach (Item item1 in items)
                {
                    Dictionary<string, string> itemDict = new Dictionary<string, string>();
                    itemDict["ItemId"] = item1.ItemId.ToString();
                    itemDict["Name"] = item1.Name.ToString();
                    itemDict["Quantity"] = item1.Quantity.ToString();
                    itemDicts.Add(itemDict);

                }
                return Json(itemDicts);
            }
            else
            {
                return Json(false);
            }

        }
    }
}
