namespace Progect_1.Storage.Entity
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public string IndredientForFood { get; set; }
        public string IndredientForDrink { get; set; }
        public int Grams { get; set; }
        public int Liters { get; set; }
        /*public Ingredient(Guid id, string ingredientForFood, string ingredientForDrink, int grams, int liters)
        {
            Id = id;
            IndredientForFood = ingredientForFood;
            IndredientForDrink = ingredientForDrink;
            Grams = grams;
            Liters = liters;
        }*/
    }
}
