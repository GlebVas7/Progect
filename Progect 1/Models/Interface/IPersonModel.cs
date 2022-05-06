using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IPersonModel
    {
        Task <IList<Person>> getAllPersons();
        Task GetPersonById(int id);
        Task CreatePerson(int person);
        Task DeletePerson(int id);
    }
}
