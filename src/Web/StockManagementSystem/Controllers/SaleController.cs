using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            Client client = new Client();
            ViewData["Clients"] = client.GetAllClients(null);

            ItemCategory category = new ItemCategory();
            ViewData["Categories"] = category.GetAllItemCategories(null);
            return View();
        }
        [HttpPost]
        public IActionResult SaleEntry(Sale sale)
        {
            string errorMsg = string.Empty;
            Item item = new Item();
            int availableQty = item.GetAllItems(sale.ItemId)[0].Quantity;
            if (availableQty < sale.Quantity)
            {
                errorMsg = "Stocked out!! Sale quantity is higer than available quantity";
                TempData["errMsg"] = errorMsg;
            }
            else
            {

                errorMsg = sale.SaveSale(sale);
                TempData["succMsg"] = errorMsg;
            }

            return RedirectToAction("Index");
        }
    }
}
