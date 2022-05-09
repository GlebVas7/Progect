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
        [HttpGet]
        [Route("creator")]
        public async Task<IList<Creator>> GetAll() => await _manager.getAllCreator();
        [HttpDelete] //не уверена,что удаление правильно реализовано(в тех контроллерах,где оно есть)
        [Route("creators/{Id}")]
        public Task Delete([FromBody] Guid Id) => _manager.deleteCreator(Id);
    }
}
