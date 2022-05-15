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
        public async Task<IActionResult> Review()
        {
            var review = await _manager.OutputData();
            return View(review);
        }
        [HttpGet]
        [Route("review")]
        public async Task<IList<Review>> GetAll() => await _manager.OutputData();

        [HttpPut]
        [Route("review")]
        public async Task Create([FromBody] Review reviews) => await _manager.AddComment(reviews);
    }
}
