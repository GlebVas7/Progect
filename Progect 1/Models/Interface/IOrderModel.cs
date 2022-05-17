using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IOrderModel
    {
        Task AddOrder(string NameOfFood, string NameOfDrink, string Name, string Lastname, string Adress);
        Task<IList<Order>> OutputData();
    }
}
