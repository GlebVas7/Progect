namespace Progect_1.Storage.Entity
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public int Price { get; set; }
        public Menu(Guid id, string nameOfFood, int price)
        {
            Id = id;
            NameOfFood = nameOfFood;    
            Price = price;
        }
    }
}
