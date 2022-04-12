using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class Cafe_StaffModel : ICafe_StaffModel
    {
        private ExampleContex _dbContext;
        public Cafe_StaffModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public Storage.Entity.Cafe_Staff CreateStaff(Cafe_Staff person)
        {
            throw new NotImplementedException();
        }

        public void DeleteStaff(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Storage.Entity.Cafe_Staff> getAllStaff()
        {
            throw new NotImplementedException();
        }

        public Storage.Entity.Cafe_Staff GetStaffById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
