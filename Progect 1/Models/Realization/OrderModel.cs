using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class OrderModel : IOrderModel
    {
        private ExampleContex _dbContext;
        private bool flag = false;
        public OrderModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task AddNewOrder(Order order)
        {
            
                order.Id = Guid.NewGuid();
                if (order.Id != null)
                {
                    _dbContext.Add(order);
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
