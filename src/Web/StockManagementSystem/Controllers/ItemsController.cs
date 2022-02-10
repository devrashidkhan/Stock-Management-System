using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models;
using StockManagementSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult ItemList()
        {
            ItemCategory itemCategory = new ItemCategory();
            ViewData["Categories"] = itemCategory.GetAllItemCategories(null);

            CategoryItemView categoryItemView = new CategoryItemView();

            List<CategoryItemView> categoryItems = categoryItemView.GetAllItems(null);

            return View(categoryItems);
        }
        [HttpPost]
        public IActionResult AddNewItem(string categoryId, int itemId, string itemName, string itemDetails,int itemQuantity)
        {
            Item item = new Item();
            item.CategoryId =  Convert.ToInt32(categoryId);
            item.ItemId = itemId;
            item.Name = itemName;
            item.ItemDetails = itemDetails;
            item.Quantity = itemQuantity;
            TempData["succMsg"] = item.SaveItem(item);
            return RedirectToAction("ItemList");
        }
        [HttpPost]
        public IActionResult DeleteItemById(int ItemId)
        {
            Item item = new Item();
            item.DeleteItemById(ItemId);
            return RedirectToAction("ItemList");
        }
    }
}
