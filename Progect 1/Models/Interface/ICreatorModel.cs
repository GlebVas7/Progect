using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ICreatorModel
    {
        Task deleteCreator(Guid id);
        List<Creator> getAllCreator();

    }
}
