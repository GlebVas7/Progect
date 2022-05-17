using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderModel _manager;
        public OrderController(IOrderModel manager)
        {
            _manager = manager;
        }
        [HttpPost]
        public async Task<IActionResult> Order(string NameOfFood, string NameOfDrink, string Name, string Lastname, string Adress)
        {
            if (NameOfFood != null && NameOfDrink != null && Name != null && Lastname != null && Adress != null)
            {
                await _manager.AddOrder(NameOfFood, NameOfDrink, Name, Lastname, Adress);
            }
            return RedirectToAction("Order");
        }
    }
}