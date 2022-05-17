using Progect_1.Storage.Entity;

namespace Progect_1.Models.Interface
{
    public interface IReviewModel
    {
        Task<IList<Review>> OutputData();
        Task AddComment(string Lastname, string Name, string Review);
        Task DeleteComment(Guid id);
    }
}
