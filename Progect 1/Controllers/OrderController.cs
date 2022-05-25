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
        public IActionResult Order()
        {
            return View();
        }
        [HttpGet]
        public IActionResult OrderComplete()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Order(string NameOfFood, string NameOfDrink, string Name, string Phone, string Adress)
        {
            if (NameOfFood != null && NameOfDrink != null && Name != null && Phone != null && Adress != null)
            {
                await _manager.AddOrder(NameOfFood, NameOfDrink, Name, Phone, Adress);
            }
            return RedirectToAction("OrderComplete");
        }
    }
}