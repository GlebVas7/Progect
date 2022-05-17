using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ICreatorModel
    {
        Task <IList<Creator>> getAllCreator();
    }
}
