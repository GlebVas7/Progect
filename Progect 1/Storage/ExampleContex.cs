
using Microsoft.EntityFrameworkCore;
using Progect_1.Storage.Entity;
namespace Progect_1.Storage
{
    public class ExampleContex: DbContext
    {
        public List<Person> Persons { get; set; }
        public IEnumerable<Creator> Creators { get; set; }
        public IEnumerable<GeoDatas> geoDatas { get; set; }
        public IEnumerable<Cafe_Staff> Cafe_Staffs { get; set; }
        public IEnumerable<Menu> Menus { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<Special_offer> Special_Offers { get; set; }
        public ExampleContex()
        {

            geoDatas = new List<GeoDatas>();
            Creators = new List<Creator>();
            Persons = new List<Person>();
            Cafe_Staffs = new List<Cafe_Staff>();
            Menus = new List<Menu>();
            Ingredients = new List<Ingredient>();
            Orders = new List<Order>();
            Reviews = new List<Review>();
            Special_Offers = new List<Special_offer>();

        }

    }
}
