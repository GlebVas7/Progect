using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IOrderModel
    {
        Task DeleteOrder(Guid Id);
        Task AddNewDish(string nameOfFood);
        Task AddNewDrink(string nameOfDrink);

    }
}
