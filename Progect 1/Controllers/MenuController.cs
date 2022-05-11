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

        [HttpDelete] //не уверена,что удаление правильно реализовано(в тех контроллерах,где оно есть)
        [Route("menu/{id}")]
        public Task Delete([FromBody] int id) => _manager.DeleteData(id);
    }
}
