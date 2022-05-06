using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ICafe_StaffModel
    {
        Task<IList<Cafe_Staff>> getAllStaff();
        Task GetStaffById(Guid id); // сомневаюсь что нужно
        Task CreateStaff(Cafe_Staff person);
        Task DeleteStaff(Guid id);
    }
}
