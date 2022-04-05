using Progect_1.Storage;
using Microsoft.AspNetCore.Mvc;
using Progect_1.Storage.Entity;
namespace Progect_1.Managers.Persons
{
    public class PersonManager: IPerson
    {
        private ExampleContex _context;
        public PersonManager()
        {
            _context = new ExampleContex();
        }

        public void Delete(Guid id)
        {
            var persons = _context.Persons.FirstOrDefault(st => st.Id == id);
            if (persons != null)
            {
                _context.Persons.Remove(persons);
            }
        }
        public ICollection<Person> GetALL()
        {
            return _context.Persons;
        }
    }
}
