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
       
        public async Task<IList<Ingredient>> GetAllIngredients() => await _dbContext.Ingredients.ToListAsync();

    }
}
