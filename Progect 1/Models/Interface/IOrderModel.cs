using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IOrderModel
    {
        Task DeleteOrder(Guid Id);
        Task AddNewOrder(Order order);

    }
}
