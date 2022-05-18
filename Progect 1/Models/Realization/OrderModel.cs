using Microsoft.EntityFrameworkCore;
using Progect_1.Models.Interface;
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
        public async Task AddOrder(string NameOfFood, string NameOfDrink, string Name, string Lastname, string Adress)
        {
            var order = new Order { Id = Guid.NewGuid(), NameOfFood = NameOfFood, NameOfDrink = NameOfDrink, Name = Name, Lastname = Lastname, Adress = Adress};

            _dbContext.Add(order);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IList<Order>> OutputData() => await _dbContext.Orders.ToListAsync();
    }
}
