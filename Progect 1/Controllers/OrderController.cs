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
        /*public async Task<IActionResult> Index()
        {
         
            return View(order);
        }*/
        [HttpPut]
        [Route("order")]
        public Task Create([FromBody] Order order) => _manager.AddNewOrder(order);

    }
}
