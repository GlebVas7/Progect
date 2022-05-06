using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IIngredientModel
    {
        Task DeleteIngredient(int Id);
        Task <IList<Ingredient>> GetAllIngredients();
        Task AddIngredient(int ingridient);

    }
}
