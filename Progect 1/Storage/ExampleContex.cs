
using Microsoft.EntityFrameworkCore;
using Progect_1.Storage.Entity;
namespace Progect_1.Storage
{
    public class ExampleContex: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<GeoDatas> geoDatas { get; set; }
        public DbSet<Cafe_Staff> Cafe_Staffs { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SpecialOffer> Special_Offers { get; set; }
        public ExampleContex(DbContextOptions<ExampleContex> options):base(options)
        {

            //geoDatas = new List<GeoDatas>();
            //Creators = new List<Creator>();
            //Persons = new List<Person>();
            //Cafe_Staffs = new List<Cafe_Staff>();
            //Menus = new List<Menu>();
            //Ingredients = new List<Ingredient>();
            //Orders = new List<Order>();
            //Reviews = new List<Review>();
            //Special_Offers = new List<SpecialOffer>();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=localhost;Database=ExampleDb;Trusted_Connection=True;");
        }
    }
}
