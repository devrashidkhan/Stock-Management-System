using Microsoft.AspNetCore.Mvc;
using StockManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult ClientsList()
        {
            Client client = new Client();
            List<Client> clients = client.GetAllClients(null);
            return View(clients);
        }
        [HttpPost]
        public IActionResult AddNewClient(String name, String phoneNumber, int clientId)
        {
            Client client = new Client();
            client.ClientId = clientId;
            client.Name = name;
            client.PhoneNumber = phoneNumber;
            TempData["succMsg"]=client.SaveClient(client);
            return RedirectToAction("ClientsList");
        }
        [HttpPost]
        public IActionResult DeleteClientById(int clientId)
        {
            Client client = new Client();
            TempData["succMsg"] = client.DeleteClientById(clientId);
            return RedirectToAction("ClientsList");
        }
    }
}
