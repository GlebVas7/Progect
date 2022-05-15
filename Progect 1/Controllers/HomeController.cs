using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage;
using System.Diagnostics;

namespace Progect_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo };
            return View(model);
        }

        public IActionResult Menu()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo };
            return View(model);
            
        }

        public IActionResult Ihdex()
        {
            return View();
        }

        public IActionResult staff()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}