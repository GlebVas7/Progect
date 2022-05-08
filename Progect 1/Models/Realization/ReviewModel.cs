using Progect_1.Models.Interface;
using Progect_1.Storage.Entity;

namespace Progect_1.Models.Realization
{
    public class ReviewModel : IReviewModel
    {
        public Task AddComment(string reviews, Person person)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComment(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Review>> OutputData()
        {
            throw new NotImplementedException();
        }
    }
}
