namespace Progect_1.Storage.Entity
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public string NameOfDrink { get; set; }
        public int Grams { get; set; }
        public int Price { get; set; }
        /*public Menu(Guid id, string nameOfFood, string nameOfDrink, int price, int grams)
        {
            Id = id;
            NameOfFood = nameOfFood;
            NameOfDrink = nameOfDrink;
            Grams = grams;
            Price = price;
        }*/
    }
}
