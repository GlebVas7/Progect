using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IIngredientModel
    {
        Task <IList<Ingredient>> GetAllIngredients();
        
    }
}
