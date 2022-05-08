using Microsoft.EntityFrameworkCore;
using Progect_1.Models.Interface;
using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models.Realization
{
    public class ReviewModel : IReviewModel
    {
        private ExampleContex _dbContext;
        public ReviewModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task AddComment(string reviews, Person person)
        {
            var item = new Review
            {
                Id = Guid.NewGuid(),
                Reviews = reviews
            };
            if (item.Id != null && person.Id != null)
            {
                item.Id = person.Id;
                _dbContext.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task DeleteComment(Guid id)
        {
            var entity = _dbContext.Reviews.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Reviews.Remove(entity);
            await _dbContext.SaveChangesAsync();;
        }

        public async Task<IList<Review>> OutputData() => await _dbContext.Reviews.ToListAsync();
    }
}
