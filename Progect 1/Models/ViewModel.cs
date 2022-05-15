using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class ViewModel
    {
        public IEnumerable<Creator> Creators { get; set; }
        public IEnumerable<GeoDatas> GeoDatas { get; set; }
        public IEnumerable<Drink> Drinks { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Menu> Menu { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public IEnumerable<Cafe_Staff> Cafe_Staffs { get; set; }

    }
}
