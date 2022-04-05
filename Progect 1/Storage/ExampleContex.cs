
using Progect_1.Storage.Entity;
namespace Progect_1.Storage
{
    public class ExampleContex
    {
        public List<Person> Persons { get; set; }

        public ExampleContex()
        {
            Persons = new List<Person>();
        }
    }
}
