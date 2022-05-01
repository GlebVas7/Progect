using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class Ingredient
    {
        [Key]
        public Guid Id { get; set; }
        public string IndredientForFood { get; set; }
        public string IndredientForDrink { get; set; }
        public int Grams { get; set; }
        public int Liters { get; set; }
    }
}
