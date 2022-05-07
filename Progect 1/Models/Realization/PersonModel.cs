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
            if (person.Id != null || person.Id != null)
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
        public async Task<IList<Person>> getAllPersons() => await _dbContext.Persons.ToListAsync();

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
