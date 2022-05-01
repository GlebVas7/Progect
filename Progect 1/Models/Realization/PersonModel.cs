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

        public Person CreatePerson(Person person)
        {
            if (person.Id != null || person.Id != null)
            {
                _dbContext.Add(person);
            }
            else
            {
                throw new NotImplementedException();
            }
            return person;
        }

        public void DeletePerson(Guid id)
        {
            var entity = _dbContext.Persons.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Persons.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Person> getAllPersons()
        {
            return _dbContext.Persons.ToList();
        }

        public Person GetPersonById(Guid id)
        {
            var person =  _dbContext.Persons.FirstOrDefault(x => x.Id == id);

            if(person == null)
                throw new NotImplementedException();

            return person;
        }
    }
}
