using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IPersonModel
    {
        List<Person> getAllPersons();
        Person GetPersonById(Guid id);
        Person CreatePerson(Person person);
        void DeletePerson(Guid id);
    }
}
