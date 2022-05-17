using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class GeoDatasController : Controller
    {
        private readonly IGeoDatasModel _manager;
        public GeoDatasController(IGeoDatasModel manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var geoData = await _manager.GetAllGeoDatas();
            return View(geoData);
        }
        [HttpGet]
        [Route("geoData")]
        public async Task<IList<GeoDatas>> GetAll() => await _manager.GetAllGeoDatas();

        [HttpPut]
        public Task Create([FromBody] GeoDatas geoData) => _manager.AddGeo(geoData);
    }
}
