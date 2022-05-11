using Microsoft.EntityFrameworkCore;
using Progect_1.Models.Interface;
using Progect_1.Storage;
using Progect_1.Storage.Entity;
namespace Progect_1.Models
{
    public class DrinkModel : IDrinkModel
    {
        private ExampleContex _dbContext;
        public DrinkModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task AddData(Drink drink)
        {
            drink.Id = new int();
            if (drink.Id != null)
            {
                _dbContext.Add(drink);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task DeleteData(int id)
        {
            var entity = _dbContext.Drinks.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Drinks.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<Drink>> OutputData() => await _dbContext.Drinks.ToListAsync();
    }
}
