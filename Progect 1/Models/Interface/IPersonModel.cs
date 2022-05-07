using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IPersonModel
    {
        Task <IList<Person>> getAllPersons();
       // Task GetPersonById(Guid id);
        Task CreatePerson(Person person);
        Task DeletePerson(Guid id);
    }
}
