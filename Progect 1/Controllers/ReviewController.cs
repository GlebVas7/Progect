using Microsoft.AspNetCore.Mvc;
using Progect_1.Models;
using Progect_1.Models.Interface;
using Progect_1.Storage.Entity;

namespace Progect_1.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewModel _manager;
        public ReviewController(IReviewModel manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var review = await _manager.OutputData();
            return View(review);
        }
        [HttpGet]
        [Route("review")]
        public async Task<IList<Review>> GetAll() => await _manager.OutputData();

        [HttpPut]
        [Route("review")]
        public Task Create([FromBody] Review review) => _manager.AddComment(review);
    }
}
