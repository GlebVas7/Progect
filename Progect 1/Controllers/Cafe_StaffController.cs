using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class Cafe_StaffController : Controller
    {
        private readonly ICafe_StaffModel _manager;
        public Cafe_StaffController(ICafe_StaffModel manager)
        {
            _manager = manager;
        }
        [HttpGet]
        [Route("cafe_staff")]
        public async Task<IList<Cafe_Staff>> GetAll() => await _manager.getAllStaff();
        [HttpPut]
        [Route("cafe_staff")]
        public Task Create([FromBody] Cafe_Staff cafe_Staff) => _manager.CreateStaff(cafe_Staff);
    }
}
