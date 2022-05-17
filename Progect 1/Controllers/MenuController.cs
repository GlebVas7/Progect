using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Models.Interface;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuModel _manager;
        public MenuController(IMenuModel manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var menu = await _manager.OutputData();
            return View(menu);
        }
        [HttpGet]
        [Route("menu")]
        public async Task<IList<Menu>> GetAll() => await _manager.OutputData();

        [HttpPut]
        [Route("menu")]
        public Task Create([FromBody] Menu menu) => _manager.AddData(menu);

        public IActionResult AddDish(int id)
        {
            var menu = _manager.FindFood(id);
            return View(menu);
        }
        public IActionResult AddDrink(int id)
        {
            var menu = _manager.FindDrink(id);
            return View(menu);
        }
    }
}
