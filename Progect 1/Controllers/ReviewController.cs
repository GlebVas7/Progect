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
        [HttpGet]
        public async Task<IActionResult> Review()
        {
            var reviews = await _manager.OutputData();
            return View(reviews);
        }
        [HttpPost]
        public async Task<IActionResult> Review(string Name, string Lastname, string Review)
        {
            if (Name != null && Lastname != null && Review != null)
            {
                await _manager.AddComment(Lastname, Name, Review);
            }
            return RedirectToAction("Review");
        }
    }
}
