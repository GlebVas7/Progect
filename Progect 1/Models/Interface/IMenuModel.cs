using Progect_1.Storage.Entity;

namespace Progect_1.Models.Interface
{
    public interface IMenuModel
    {
        Task AddData(Menu menu);
        Task DeleteData(int id);
        Task<IList<Menu>> OutputData();
        int FindFood(int id);
        int FindDrink(int id);
    }
}
