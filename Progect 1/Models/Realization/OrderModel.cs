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
        public Order AddNewDish(Order nameOfFood)
        {
            if (nameOfFood.Id != null || nameOfFood.Id != null)
            {
                _dbContext.Add(nameOfFood);
            }
            else
            {
                throw new NotImplementedException();
            }
            return nameOfFood;
        }

        public Order AddNewDrink(Order nameOfDrink)
        {
            if (nameOfDrink.Id != null || nameOfDrink.Id != null)
            {
                _dbContext.Add(nameOfDrink);
            }
            else
            {
                throw new NotImplementedException();
            }
            return nameOfDrink;
        }

        public void DeleteOrder(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
