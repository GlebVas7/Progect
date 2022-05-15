using Progect_1.Storage.Entity;
namespace Progect_1.Models.Interface
{
    public interface IDrinkModel
    {
        Task AddData(Drink drink);
        Task DeleteData(int id);
        Task<IList<Drink>> OutputData();
    }
}
