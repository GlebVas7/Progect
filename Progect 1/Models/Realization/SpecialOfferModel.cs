using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class SpecialOfferModel : ISpecialOfferModel
    {
        private ExampleContex _dbContext;
        public SpecialOfferModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public SpecialOffer AddNewDish(SpecialOffer nameOfFood)
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

        public SpecialOffer AddNewDrink(SpecialOffer nameOfDrink)
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

        public SpecialOffer ChangeDate(SpecialOffer DataOfSpecialOffer)
        {
            throw new NotImplementedException();
        }

        public SpecialOffer ChangePrice(SpecialOffer Price)
        {
            throw new NotImplementedException();
        }

        public void DeleteSpecialOffer(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
