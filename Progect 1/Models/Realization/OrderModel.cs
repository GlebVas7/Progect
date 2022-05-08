using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class OrderModel : IOrderModel
    {
        private ExampleContex _dbContext;
        public OrderModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task AddNewDish(string nameOfFood)
        {
            var item = new Order {
                Id = Guid.NewGuid(),
                NameOfFood = nameOfFood
            };
            
            if (item.Id != null)
            {
                _dbContext.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
           
        }

        public async Task AddNewDrink(string nameOfDrink)
        {
            var item = new Order
            {
                NameOfDrink = nameOfDrink
            };

            if (item.Id != null)
            {
                _dbContext.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task DeleteOrder(Guid Id)
        {
            var entity = _dbContext.Orders.FirstOrDefault(x => x.Id == Id);
            if (entity != null)
                _dbContext.Orders.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
