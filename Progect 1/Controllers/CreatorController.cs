using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class CreatorController : Controller
    {
        private readonly ICreatorModel _manager;
        public CreatorController(ICreatorModel manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var creator = await _manager.getAllCreator();
            return View(creator);
        }
        [HttpGet]
        [Route("creator")]
        public async Task<IList<Creator>> GetAll() => await _manager.getAllCreator();
        [HttpDelete] 
        [Route("creators/{Id}")]
        public Task Delete([FromBody] Guid Id) => _manager.deleteCreator(Id);
    }
}
