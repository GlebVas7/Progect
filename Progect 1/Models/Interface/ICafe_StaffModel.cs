using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ICafe_StaffModel
    {
        List<Cafe_Staff> getAllStaff();
        Guid GetStaffById(Guid id);
        Person CreateStaff(Person person);
        void DeleteStaff(Guid id);
    }
}
