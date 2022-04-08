namespace Progect_1.Storage.Entity
{
    public class Orders
    {
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public string NameOfDrink { get; set; }
        public int Price_Of_Order { get; set; }
        public Orders(Guid id, string nameOfFood, string nameOfDrink, int price_of_order)
        {
            Id = id;
            NameOfFood = nameOfFood;
            NameOfDrink = nameOfDrink;
            Price_Of_Order = price_of_order;
        }
    }
}
