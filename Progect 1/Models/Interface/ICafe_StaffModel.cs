using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ICafe_StaffModel
    {
        Task<IList<Cafe_Staff>> getAllStaff();
        Task CreateStaff(Cafe_Staff person);
    }
}
