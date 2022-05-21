using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Models.Interface;
using Progect_1.Storage;
using System.Diagnostics;

namespace Progect_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReviewModel _manager;
        public HomeController(ILogger<HomeController> logger, IReviewModel manager)
        {
            _logger = logger;
            _manager = manager;
        }

        public IActionResult Index()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var cafe_staff = db.Cafe_Staffs.ToList();
            var drink = db.Drinks.ToList();
            var ingredient = db.Ingredients.ToList();
            var review = db.Reviews.ToList();
            var order = db.Orders.ToList();
            var menu = db.Menus.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo, Cafe_Staffs = cafe_staff, Drinks = drink, Ingredients = ingredient, Reviews = review, Orders = order, Menu = menu };
            return View(model);

        }

        public IActionResult Menu()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var cafe_staff = db.Cafe_Staffs.ToList();
            var drink = db.Drinks.ToList();
            var ingredient = db.Ingredients.ToList();
            var review = db.Reviews.ToList();
            var order = db.Orders.ToList();
            var menu = db.Menus.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo, Cafe_Staffs = cafe_staff, Drinks = drink, Ingredients = ingredient, Reviews = review, Orders = order, Menu = menu};
            return View(model);
            
        }

        public IActionResult Ihdex()
        {
            return View();
        }

        public IActionResult Order()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var cafe_staff = db.Cafe_Staffs.ToList();
            var drink = db.Drinks.ToList();
            var ingredient = db.Ingredients.ToList();
            var review = db.Reviews.ToList();
            var order = db.Orders.ToList();
            var menu = db.Menus.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo, Cafe_Staffs = cafe_staff, Drinks = drink, Ingredients = ingredient, Reviews = review, Orders = order, Menu = menu };
            return View(model);
        }

        public IActionResult staff()
        {
            var db = new ExampleContex();
            var geo = db.geoDatas.ToList();
            var creator = db.Creators.ToList();
            var cafe_staff = db.Cafe_Staffs.ToList();
            var drink = db.Drinks.ToList();
            var ingredient = db.Ingredients.ToList();
            var review = db.Reviews.ToList();
            var order = db.Orders.ToList();
            var menu = db.Menus.ToList();
            var model = new ViewModel { Creators = creator, GeoDatas = geo, Cafe_Staffs = cafe_staff, Drinks = drink, Ingredients = ingredient, Reviews = review, Orders = order, Menu = menu };
            return View(model);

        }
        public async Task<IActionResult> Review()
        {
            var reviews = await _manager.OutputData();
            return View(reviews);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}