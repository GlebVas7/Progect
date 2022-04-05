using Microsoft.AspNetCore.Mvc;
using Progect_1.Managers.Persons;

namespace Progect_1.Controllers
{
    public class PersonController: Controller
    {
        private IPerson _manager;
        public PersonController()
        {
            _manager = new PersonManager();
        }

        public IActionResult Index()
        {
            var persons = _manager.GetALL();
            return View(persons);
        }
    }
}
