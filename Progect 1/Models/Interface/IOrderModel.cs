using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IOrderModel
    {
        void DeleteOrder(Guid Id);
        Order AddNewDish(Order nameOfFood);
        Order AddNewDrink(Order nameOfDrink);

    }
}
