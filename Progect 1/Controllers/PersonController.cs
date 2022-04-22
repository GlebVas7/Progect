using Microsoft.AspNetCore.Mvc;
using Progect_1.Managers.Person;
using Progect_1.Models;

namespace Progect_1.Controllers
{
    public class PersonController: Controller
    {
        private IPersonManager _manager;
        public PersonController()
        {
            _manager = new PersonManager();
        }

        public IActionResult Index()
        {
            var persons = _manager.GetAll();
            return View(persons);
        }
    }
}
