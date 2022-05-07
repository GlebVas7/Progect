using Microsoft.EntityFrameworkCore;
using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class IngredientModel : IIngredientModel
    {
        private ExampleContex _dbContext;
        public IngredientModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task AddIngredient(Ingredient ingridient)
        {
            ingridient.Id = Guid.NewGuid();
            if (ingridient.Id != null || ingridient.Id != null)
            {
                _dbContext.Add(ingridient);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task DeleteIngredient(Guid Id)
        {
            var entity = _dbContext.Ingredients.FirstOrDefault(x => x.Id == Id);
            if (entity != null)
                _dbContext.Ingredients.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<Ingredient>> GetAllIngredients() => await _dbContext.Ingredients.ToListAsync();

    }
}
