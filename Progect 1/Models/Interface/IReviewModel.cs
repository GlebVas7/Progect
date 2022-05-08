using Progect_1.Storage.Entity;

namespace Progect_1.Models.Interface
{
    public interface IReviewModel
    {
        Task AddComment(string reviews, Person person);
        Task <IList<Review>>OutputData();
        Task DeleteComment(Guid id);
    }
}
