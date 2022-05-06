using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ISpecialOfferModel
    {
        Task DeleteSpecialOffer(int Id);
        Task AddNewDish(string nameOfFood);
        Task AddNewDrink(string nameOfDrink);
        Task ChangeDate(int DataOfSpecialOffer);
        Task ChangePrice(int Price);
    }
}
