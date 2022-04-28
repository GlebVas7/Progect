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
        public Cafe_Staff CreateStaff(Cafe_Staff person)
        {
            if (person.Name != null || person.Lastname != null)
            {
                _dbContext.Add(person);
            }
            else
            {
                throw new NotImplementedException();
            }
            return person;
        }

        public void DeleteStaff(Guid id)
        {

           var entity = _dbContext.Cafe_Staffs.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Cafe_Staffs.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Cafe_Staff> getAllStaff()
        {
            throw new NotImplementedException();
        }

        public Cafe_Staff GetStaffById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
