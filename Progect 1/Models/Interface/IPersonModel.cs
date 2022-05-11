using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IPersonModel
    {
        Task <IList<Person>> getAllPersons();
       // Task GetPersonById(Guid id);
        Task CreatePerson(Person person);
        Task DeletePerson(Guid id);
        Task<Person> FindUserByNamePasswordAsync(string name, string password);
        Task<Person> FindUserByNameAsync(string name);
        Task AddUserToDataBase(string name, string password, string confirmPassword);
    }
}
