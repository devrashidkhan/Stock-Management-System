using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models;
using StockManagementSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult PurchaseHistory()
        {
            Vendor vendor = new Vendor();
            ViewData["Vendors"] = vendor.GetAllVendor(null);

            

            PurchaseHistoryView ph = new PurchaseHistoryView();
           

            List<PurchaseHistoryView> purchaseHistoryViews = ph.GetAllPurchaseHistory(ph,null,null);
            return View(purchaseHistoryViews);
        }

        [HttpPost]
        public IActionResult PurchaseHistory(DateTime? dateFrom, DateTime? dateTo)
        {
            Vendor vendor = new Vendor();
            ViewData["Vendors"] = vendor.GetAllVendor(null);

            PurchaseHistoryView ph = new PurchaseHistoryView();

            List<PurchaseHistoryView> purchaseHistoryViews = ph.GetAllPurchaseHistory(ph, dateFrom, dateTo);
            return View(purchaseHistoryViews);
        }

        public IActionResult SaleHistory()
        {
            Client vendor = new Client();
            ViewData["Clients"] = vendor.GetAllClients(null);



            SaleHistoryView sh = new SaleHistoryView();


            List<SaleHistoryView> saleHistoryViews = sh.GetAllSaleHistory(sh, null, null);
            return View(saleHistoryViews);
        }

        [HttpPost]
        public IActionResult SaleHistory(DateTime? dateFrom, DateTime? dateTo)
        {
            Client vendor = new Client();
            ViewData["Clients"] = vendor.GetAllClients(null);

            SaleHistoryView sh = new SaleHistoryView();

            List<SaleHistoryView> saleHistoryViews = sh.GetAllSaleHistory(sh, dateFrom, dateTo);
            return View(saleHistoryViews);
        }

    }
}
