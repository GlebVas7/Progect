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
        public async Task AddNewDish(string nameOfFood)
        {
            var item = new SpecialOffer
            {
                Id = Guid.NewGuid(),
                NameOfFood = nameOfFood
            };

            if (item.Id != null || item.Id != null)
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
            var item = new SpecialOffer
            {
                Id = Guid.NewGuid(),
                NameOfDrink = nameOfDrink
            };
            if (item.Id != null || item.Id != null)
            {
                _dbContext.Add(item);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task ChangeDate(int DataOfSpecialOffer)
        {
            var item = new SpecialOffer
            {
                Id = Guid.NewGuid(),
                Data_Of_Special_Offer = DataOfSpecialOffer
            };
            await _dbContext.SaveChangesAsync();
        }

        public async Task ChangePrice(int Price)
        {
            var item = new SpecialOffer
            {
                Id = Guid.NewGuid(),
                Price = Price
            };
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteSpecialOffer(Guid Id)
        {
            var entity = _dbContext.Special_Offers.FirstOrDefault(x => x.Id == Id);
            if (entity != null)
                _dbContext.Special_Offers.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
