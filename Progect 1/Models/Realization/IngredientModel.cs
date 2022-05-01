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
        public Ingredient AddIngredient(Ingredient ingridient)
        {
            if (ingridient.Id != null || ingridient.Id != null)
            {
                _dbContext.Add(ingridient);
            }
            else
            {
                throw new NotImplementedException();
            }
            return ingridient;
        }

        public void DeleteIngredient(Guid Id)
        {
            var entity = _dbContext.Ingredients.FirstOrDefault(x => x.Id == Id);
            if (entity != null)
                _dbContext.Ingredients.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<Ingredient> GetAllIngredients()
        {
            throw new NotImplementedException();
        }
    }
}
