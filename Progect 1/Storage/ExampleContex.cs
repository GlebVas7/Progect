
using Microsoft.EntityFrameworkCore;
using Progect_1.Storage.Entity;
namespace Progect_1.Storage
{
    public class ExampleContex: DbContext
    {
        public List<Person> Persons { get; set; }
        public IEnumerable<Creator> Creators { get; set; }
        public IEnumerable<GeoDatas> geoDatas { get; set; }
        public ExampleContex()
        {

            geoDatas = new List<GeoDatas>();
            Creators = new List<Creator>();
            Persons = new List<Person>();
        }
    }
}
