using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IIngredientModel
    {
        void DeleteIngredient(Guid Id);
        List<Ingredient> GetAllIngredients();
        Ingredient AddIngredient(Guid id);

    }
}
