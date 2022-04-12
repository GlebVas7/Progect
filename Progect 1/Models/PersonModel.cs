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
            throw new NotImplementedException();
        }

        public void DeletePerson(Guid id)
        {
            throw new NotImplementedException();
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
