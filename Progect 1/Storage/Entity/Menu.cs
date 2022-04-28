using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class Menu
    {
        [Key]
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public string NameOfDrink { get; set; }
        public int Grams { get; set; }
        public int Price { get; set; }
        
    }
}
