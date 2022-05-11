using Microsoft.EntityFrameworkCore;
using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class PersonModel : IPersonModel
    {
        private ExampleContex _dbContext;
        public PersonModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task CreatePerson(Person person)
        {
            person.Id = Guid.NewGuid();
            if (person.Id != null)
            {
                _dbContext.Add(person);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task DeletePerson(Guid id)
        {
            var entity = _dbContext.Persons.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Persons.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Person> FindUserByNamePasswordAsync(string userName, string userPassword)
        {
            return await _dbContext.Persons.FirstOrDefaultAsync(u => u.Name == userName && u.Pass == userPassword);
        }
        public async Task<Person> FindUserByNameAsync(string userName)
        {
            return await _dbContext.Persons.FirstOrDefaultAsync(u => u.Name == userName);
        }
        public async Task<IList<Person>> getAllPersons() => await _dbContext.Persons.ToListAsync();
        public async Task AddUserToDataBase(string userName, string userPassword, string phone)
        {
            _dbContext.Persons.Add(new Person { Id = Guid.NewGuid(), Name = userName, Pass = userPassword, Phone_Number = phone });
            await _dbContext.SaveChangesAsync();
        }

        //public async Task GetPersonById(Guid id)
        //{
        // var person =  _dbContext.Persons.FirstOrDefault(x => x.Id == id);
        //  if (person.Id != null)
        //     _dbContext.Persons.Remove(person);
        //  else
        //     throw new NotImplementedException();
        //}
    }
}
