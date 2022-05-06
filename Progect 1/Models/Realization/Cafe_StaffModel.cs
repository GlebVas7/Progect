using Microsoft.EntityFrameworkCore;
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
        public async Task CreateStaff(Cafe_Staff person)
        {
            person.Id = Guid.NewGuid();
            if (person.Name != null || person.Lastname != null)
            {
                _dbContext.Add(person);
                await _dbContext.SaveChangesAsync();
            }
            else
                throw new NotImplementedException();
            
        }

        public async Task DeleteStaff(Guid id)
        {

           var entity = _dbContext.Cafe_Staffs.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Cafe_Staffs.Remove(entity);
            _dbContext.SaveChangesAsync();
        }

        public async Task<IList<Cafe_Staff>> getAllStaff() => await _dbContext.Cafe_Staffs.ToListAsync();

        public async Task GetStaffById(Guid id) // хз зачем это 
        {
            throw new NotImplementedException();
        }
    }
}
