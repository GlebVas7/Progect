using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ICafe_StaffModel
    {
        List<Cafe_Staff> getAllStaff();
        Cafe_Staff GetStaffById(Guid id);
        Cafe_Staff CreateStaff(Cafe_Staff person);
        void DeleteStaff(Guid id);
    }
}
