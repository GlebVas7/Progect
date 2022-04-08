namespace Progect_1.Storage.Entity
{
    public class Special_offer
    {
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public string NameOfDrink { get; set; }
        public int Price { get; set; }
        public int Data_Of_Special_Offer { get; set; }
        public Special_offer(Guid id, string nameOfFood, string nameOfDrink, int price, int data_of_special_offer)
        {
            Id = id;
            NameOfFood = nameOfFood;
            NameOfDrink = nameOfDrink;
            Price = price;
            Data_Of_Special_Offer = data_of_special_offer;
        }
    }
}
